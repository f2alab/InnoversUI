using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    internal class DoubleToCornerRadius : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if( !double.TryParse(value.ToString(), out double d) )
            {
                throw new Exception("Value error! Except double but got " + value.GetType());
            }
            return new CornerRadius(d + 10);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
