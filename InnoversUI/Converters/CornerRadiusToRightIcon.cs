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
    internal class CornerRadiusToRightIconRadius : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CornerRadius Radius = ((CornerRadius)value);
            double Plus = 1.5;
            return new CornerRadius(topLeft: 0, topRight: Radius.TopRight - Plus, bottomRight: Radius.BottomRight - Plus, bottomLeft: 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
