using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    internal class PassBoxVisibilityToBoolean : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool IsVisible = ((bool)value);
            return IsVisible ? Visibility.Hidden : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
