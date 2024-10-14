using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InnoversUI.Controls
{
    
    public class CircleButton : Button
    {
        //SIZE
        #region [SIZE]
        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(double), typeof(CircleButton), new PropertyMetadata(40.0));
        #endregion [SIZE]

       

        public SolidColorBrush SplashColor
        {
            get { return (SolidColorBrush)GetValue(SplashColorProperty); }
            set { SetValue(SplashColorProperty, value); }
        }

        public static readonly DependencyProperty SplashColorProperty =
            DependencyProperty.Register("SplashColor", typeof(SolidColorBrush), typeof(CircleButton), new PropertyMetadata(Brushes.WhiteSmoke));



        static CircleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleButton), new FrameworkPropertyMetadata(typeof(CircleButton)));
        }
    }
}
