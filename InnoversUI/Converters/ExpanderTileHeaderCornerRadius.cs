using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace InnoversUI.Converters
{
    public class ExpanderTileHeaderCornerRadius : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            CornerRadius MainCornerRadius = (CornerRadius)values[0];
            bool IsExpanded = (bool)values[1];

            return HeaderCornerRadius(IsExpanded: IsExpanded, CornerRadius: MainCornerRadius);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public CornerRadius HeaderCornerRadius(bool IsExpanded, CornerRadius CornerRadius)
        {
            if (IsExpanded)
            {
                return new CornerRadius(topLeft: CornerRadius.TopLeft, topRight: CornerRadius.TopRight, bottomLeft: 0, bottomRight: 0);
            }
            else
            {
                return new CornerRadius(topLeft: CornerRadius.TopLeft, topRight: CornerRadius.TopRight, bottomLeft: CornerRadius.BottomLeft > 0 ? CornerRadius.BottomLeft - 1 : 0, bottomRight: CornerRadius.BottomRight > 0 ? CornerRadius.BottomRight - 1 : 0);
            }

        }
    }
}
