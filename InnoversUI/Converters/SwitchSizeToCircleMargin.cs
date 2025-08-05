using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    internal class SwitchSizeToCircleMargin : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            List<object> values = parameter as List<object>;
            double Width_Height = (double)value - (double)values[1];
            if ((bool)values[0])
            {
                return new Thickness(Width_Height, 0, 0, 0);
            }
            else
            {
                return new Thickness(0, 0, Width_Height, 0);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
