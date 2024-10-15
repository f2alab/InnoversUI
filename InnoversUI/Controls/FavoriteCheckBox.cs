using System.Windows;
using System.Windows.Controls;

namespace InnoversUI.Controls
{
    
    public class FavoriteCheckBox : CheckBox
    {
        //SIZE
        #region [SIZE]
        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(double), typeof(FavoriteCheckBox), new PropertyMetadata(80.0));
        #endregion [SIZE]

        static FavoriteCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FavoriteCheckBox), new FrameworkPropertyMetadata(typeof(FavoriteCheckBox)));
        }
    }
}
