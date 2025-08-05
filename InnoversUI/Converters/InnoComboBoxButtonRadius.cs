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
    internal class InnoComboBoxButtonRadius : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            CornerRadius CornerRadius = (CornerRadius)value;
            double Facteur = 2d;
            return new CornerRadius(0, CornerRadius.TopRight - Facteur, CornerRadius.BottomRight - Facteur, 0);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
