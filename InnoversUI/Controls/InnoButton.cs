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


        protected override void OnMouseEnter(MouseEventArgs e)
        {
            base.OnMouseEnter(e);

            SetBackgroundColor(IsMouseLeave: false);
        }

        protected override void OnMouseLeave(MouseEventArgs e)
        {
            base.OnMouseLeave(e);

            SetBackgroundColor(IsMouseLeave: true);
        }

        private void SetBackgroundColor(bool IsMouseLeave)
        {
            SolidColorBrush BackColor = Background as SolidColorBrush;
            Color Color = BackColor.Color;
            if (IsMouseLeave) { Color.A = 255; }
            else { Color.A = 220; }

            Background = new SolidColorBrush(color: Color);

        }

    }
}
