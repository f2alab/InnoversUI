using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

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
            DependencyProperty.Register("Size", typeof(double), typeof(FavoriteCheckBox), new PropertyMetadata(24.0));
        #endregion [SIZE]

        static FavoriteCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FavoriteCheckBox), new FrameworkPropertyMetadata(typeof(FavoriteCheckBox)));
        }
    }
}
