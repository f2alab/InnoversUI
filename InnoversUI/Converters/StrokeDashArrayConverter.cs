using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace InnoversUI.Converters
{
    internal class StrokeDashArrayConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values.Length < 2 ||
                !double.TryParse(values[0].ToString(), out double size) ||
                !double.TryParse(values[1].ToString(), out double thickness)
                )
            {
                return 0;
            }

            double Circonference = Math.PI * size;
            double LineLength = Circonference * 0.75;
            double GapLength = Circonference - LineLength;

            return new DoubleCollection(new[] { LineLength / thickness, GapLength / thickness });
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
