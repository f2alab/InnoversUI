using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Controls;
using InnoversUI.Controls;

namespace InnoversUI.Utils
{
    public class ImagesUtils
    {

        //OPEN AND DISPLAY IMAGE
        public static void OpenAndDisplayImage(object ImageControl )
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
                else if (ImageControl is CircleImageButton cib)
                    cib.ImageSource = new BitmapImage(new Uri(openFileDialog.FileName));
                else { return; }
            }
        }
    }
}
