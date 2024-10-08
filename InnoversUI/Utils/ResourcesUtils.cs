using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InnoversUI.Utils
{
    public class ResourcesUtils
    {
        //CHANGE RESOURCE COLOR
        public static void ChangeSolidBrushResourceColor(string ResourceKey, Brush NewSolidBrushColor)
        {
            Application.Current.Resources[ResourceKey] = NewSolidBrushColor;
        }

        public static void ChangeColorResourceColor(string ResourceKey, Color NewColor)
        {
            Application.Current.Resources[ResourceKey] = NewColor;
        }

        public static SolidColorBrush GetResourceSolidBrushColor(Control Control, string ResourceKey)
        {
            return Control.FindResource(ResourceKey) as SolidColorBrush;
        }

        public static Color GetResourceColor(Control Control, string ResourceKey)
        {
            return (Color)Control.FindResource(ResourceKey);
        }

        public static double GetResourceDouble(Control Control, string ResourceKey)
        {
            return (double)Control.FindResource(ResourceKey);
        }
    }
}
