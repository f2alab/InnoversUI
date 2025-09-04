using InnoversUI.Controls;
using Microsoft.Win32;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace InnoversUI.Utils
{
    public class ImagesUtils
    {

        //OPEN AND DISPLAY IMAGE
        public static void OpenAndDisplayImage(object ImageControl)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image |*.bmp;*.jpg;*.png",
                FilterIndex = 1,
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == true)
            {
                if (ImageControl is Image image)
                    image.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                else if (ImageControl is ImageBrush ib)
                    ib.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
                else if (ImageControl is CircleImage cib)
                    cib.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
                else { return; }
            }
        }

        public static byte[] ImageToByteArray(BitmapImage imageC)
        {
            MemoryStream memStream = new MemoryStream();
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(imageC));
            encoder.Save(memStream);
            return memStream.ToArray();
        }

        //CONVERTION BYTEARRAY EN IMAGE
        public static BitmapImage ByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }

        public static async Task<BitmapImage> ByteArrayToImageAsync(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;

            return await Task.Run(() =>
            {
                var image = new BitmapImage();
                using (var mem = new MemoryStream(imageData))
                {
                    mem.Position = 0;
                    image.BeginInit();
                    image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                    image.CacheOption = BitmapCacheOption.OnLoad;
                    image.UriSource = null;
                    image.StreamSource = mem;
                    image.EndInit();
                }
                image.Freeze(); // nécessaire pour pouvoir utiliser l'image sur le thread UI
                return image;
            });
        }

        //CONVERTION BITMAPIMAGE TO BITMAP
        public static System.Drawing.Bitmap BitmapImageToBitmap(BitmapImage BitmapImage)
        {
            using (MemoryStream OutStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(BitmapImage));
                enc.Save(OutStream);
                System.Drawing.Bitmap Bitmap = new System.Drawing.Bitmap(OutStream);

                return new System.Drawing.Bitmap(Bitmap);
            }
        }
    }
}
