using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace InnoversUI.Utils
{
    public class ColorsUtils
    {
        public static Color GetResourceColor(FrameworkElement Element, string ResourceKey)
        {
            return ResourcesUtils.GetResourceColor(Element, ResourceKey);
        }

        public static SolidColorBrush GetResourceSolidBrushColor(FrameworkElement Element, string ResourceKey)
        {
            return ResourcesUtils.GetResourceSolidBrushColor(Element, ResourceKey);
        }

        public static void ChangeColorResourceColor(string ResourceKey, Color NewColor)
        {
            ResourcesUtils.ChangeColorResourceColor(ResourceKey, NewColor);
        }

        public static void ChangeSolidBrushResourceColor(string ResourceKey, Brush NewSolidBrushColor)
        {
            ResourcesUtils.ChangeSolidBrushResourceColor(ResourceKey, NewSolidBrushColor);
        }


        //COLOR FORM HEX
        public static Color ColorFromHex(string Color)
        {
            return (Color)ColorConverter.ConvertFromString(value: Color);
        }

        //SOLID BRUSH FROM HEX
        public static SolidColorBrush SolidColorBrushFromHex(string Color)
        {
            return new SolidColorBrush(color: ColorFromHex(Color));
        }

        public static SolidColorBrush ColorToSolidColorBrush(Color Color) { return new SolidColorBrush(color: Color); }
        

    }
}
