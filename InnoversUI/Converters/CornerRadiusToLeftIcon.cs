using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    internal class CornerRadiusToLeftIconRadius : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CornerRadius Radius = ((CornerRadius)value);
            double Plus = 1.5;

            return new CornerRadius(topLeft: Radius.TopLeft - Plus, topRight: 0, bottomRight: 0, bottomLeft: Radius.BottomLeft - Plus);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
