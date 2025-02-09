using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    public class ExpanderTileHeaderCornerRadius : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            bool IsExpanded = (bool)values[0];
            bool HeaderCornerRadius = (bool)values[1];
            bool MainCornerRadius = (bool)values[2];

            return IsExpanded ? HeaderCornerRadius : MainCornerRadius;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
