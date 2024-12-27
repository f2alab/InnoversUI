using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace InnoversUI.Controls
{

    public class InnoButton : Button
    {


        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }


        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(InnoButton), new PropertyMetadata(new CornerRadius(5)));





        public Brush SplashColor
        {
            get { return (Brush)GetValue(SplashColorProperty); }
            set { SetValue(SplashColorProperty, value); }
        }
        public static readonly DependencyProperty SplashColorProperty =
            DependencyProperty.Register("SplashColor", typeof(Brush), typeof(InnoButton), new PropertyMetadata(Brushes.LightGray));




        static InnoButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnoButton), new FrameworkPropertyMetadata(typeof(InnoButton)));
            
        }

       
    }
}
