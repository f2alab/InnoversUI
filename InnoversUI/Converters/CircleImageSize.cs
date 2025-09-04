using System;
using System.Globalization;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    public class CircleImageSize : IValueConverter
    {
        // Convertit une valeur en sa moitié
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double d)
                return d / 2;
            return 0;
        }

        // Non utilisé ici
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
