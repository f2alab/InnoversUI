using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace InnoversUI.Converters
{
    public class BackColorToSplashColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            
           VisualBrush Brush = (VisualBrush)value;
            Brush.Opacity = 0.6;
            //Color Color = ((SolidColorBrush)Brush).Color;

            //Color Color = Color.FromArgb()
            return Brush;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
