using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InnoversUI.Controls
{
    
    public class CircleImage : Control
    {
        //SIZE
        #region [SIZE]
        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(double), typeof(CircleButton), new PropertyMetadata(50.0));
        #endregion [SIZE]

        //IMAGE SOURCE
        #region [IMAGE SOURCE]
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CircleButton), new PropertyMetadata(null));
        #endregion [IMAGE SOURCE]

        //IMAGE STRETCH
        #region [IMAGE STRETCH]
        public Stretch Stretch
        {
            get { return (Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        public static readonly DependencyProperty StretchProperty =
            DependencyProperty.Register("Stretch", typeof(Stretch), typeof(CircleButton), new PropertyMetadata(Stretch.UniformToFill));
        #endregion [IMAGE STRETCH]
        static CircleImage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleImage), new FrameworkPropertyMetadata(typeof(CircleImage)));
        }
    }
}
