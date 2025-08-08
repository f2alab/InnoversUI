using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InnoversUI.Utils
{
    public class ResourcesUtils
    {
        //CHANGE RESOURCE COLOR
        internal static void ChangeSolidBrushResourceColor(string ResourceKey, Brush NewSolidBrushColor)
        {
            Application.Current.Resources[ResourceKey] = NewSolidBrushColor;
        }

        internal static void ChangeColorResourceColor(string ResourceKey, Color NewColor)
        {
            Application.Current.Resources[ResourceKey] = NewColor;
        }

        internal static SolidColorBrush GetResourceSolidBrushColor(FrameworkElement Element, string ResourceKey)
        {
            return Element.FindResource(ResourceKey) as SolidColorBrush;
        }

        internal static Color GetResourceColor(FrameworkElement Element, string ResourceKey)
        {
            return (Color)Element.FindResource(ResourceKey);
        }


        public static double GetResourceDouble(FrameworkElement Element, string ResourceKey)
        {
            return (double)Element.FindResource(ResourceKey);
        }
    }
}
