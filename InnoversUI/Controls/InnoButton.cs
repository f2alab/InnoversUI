using System.Windows;
using System.Windows.Controls;

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


        static InnoButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnoButton), new FrameworkPropertyMetadata(typeof(InnoButton)));
        }
    }
}
