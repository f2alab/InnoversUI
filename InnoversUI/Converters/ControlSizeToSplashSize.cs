using System;
using System.Globalization;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    internal class ControlSizeToSplashSize : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return decimal.Parse(value.ToString()) + 10;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
