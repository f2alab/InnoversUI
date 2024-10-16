using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InnoversUI.Controls
{
    
    public class CircleImageButton : Button
    {
        //SIZE
        #region [SIZE]
        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(double), typeof(CircleImageButton), new PropertyMetadata(40.0));
        #endregion [SIZE]

        //IMAGE SOURCE
        #region [IMAGE SOURCE]
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CircleImageButton), new PropertyMetadata(null));
        #endregion [IMAGE SOURCE]

        //IMAGE STRETCH
        #region [IMAGE STRETCH]
        public Stretch Stretch
        {
            get { return (Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        public static readonly DependencyProperty StretchProperty =
            DependencyProperty.Register("Stretch", typeof(Stretch), typeof(CircleImageButton), new PropertyMetadata(Stretch.Uniform));
        #endregion [IMAGE STRETCH]

        public SolidColorBrush SplashColor
        {
            get { return (SolidColorBrush)GetValue(SplashColorProperty); }
            set { SetValue(SplashColorProperty, value); }
        }

        public static readonly DependencyProperty SplashColorProperty =
            DependencyProperty.Register("SplashColor", typeof(SolidColorBrush), typeof(CircleImageButton), new PropertyMetadata(Brushes.LightGray));


        static CircleImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleImageButton), new FrameworkPropertyMetadata(typeof(CircleImageButton)));
        }
    }
}
