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
    
    public class RoundedImage : Control
    {
        //CORNER RADUIS
        #region [CORNER RADUIS]
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }


        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RoundedImage), new PropertyMetadata(new CornerRadius(5)));
        #endregion [CORNER RADUIS]

        //SIZE
        #region [SIZE]
        //public double Size
        //{
        //    get { return (double)GetValue(SizeProperty); }
        //    set { SetValue(SizeProperty, value); }
        //}

        //public static readonly DependencyProperty SizeProperty =
        //    DependencyProperty.Register("Size", typeof(double), typeof(RoundedImage), new PropertyMetadata(80.0));
        #endregion [SIZE]

        //IMAGE SOURCE
        #region [IMAGE SOURCE]
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(RoundedImage), new PropertyMetadata(null));
        #endregion [IMAGE SOURCE]

        //IMAGE STRETCH
        #region [IMAGE STRETCH]
        public Stretch Stretch
        {
            get { return (Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        public static readonly DependencyProperty StretchProperty =
            DependencyProperty.Register("Stretch", typeof(Stretch), typeof(RoundedImage), new PropertyMetadata(Stretch.UniformToFill));
        #endregion [IMAGE STRETCH]

        //BORDER COLOR 
        #region [BORDER COLOR]
        public Brush BorderColor
        {
            get { return (Brush)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly DependencyProperty BorderColorProperty =
            DependencyProperty.Register("BorderColor", typeof(Brush), typeof(RoundedImage), new PropertyMetadata(Brushes.Transparent));
        #endregion [BORDER COLOR]

        #region [BORDER THICKNESS]


        public Thickness BorderWidth
        {
            get { return (Thickness)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static readonly DependencyProperty BorderWidthProperty =
            DependencyProperty.Register("BorderWidth", typeof(Thickness), typeof(RoundedImage), new PropertyMetadata(new Thickness(0)));


        #endregion [BORDER THICKNESS]

        #region [IS CLICKABLE]
        public bool IsClickable
        {
            get => (bool)GetValue(IsClickableProperty);
            set => SetValue(IsClickableProperty, value);
        }
        public static readonly DependencyProperty IsClickableProperty =
        DependencyProperty.Register(nameof(IsClickable), typeof(bool), typeof(RoundedImage), new PropertyMetadata(false));

        #endregion [IS CLICKABLE]

        #region [SPLASH COLOR]
        public Brush SplashColor
        {
            get => (Brush)GetValue(SplashColorProperty);
            set => SetValue(SplashColorProperty, value);
        }
        public static readonly DependencyProperty SplashColorProperty =
        DependencyProperty.Register(nameof(SplashColor), typeof(Brush), typeof(RoundedImage), new PropertyMetadata(Brushes.LightGray));

        #endregion [SPLASH COLOR]


        #region [ANIMATE ON MOUSE OVER]
        public bool AnimateOnMouseOver
        {
            get => (bool)GetValue(AnimateOnMouseOverProperty);
            set => SetValue(AnimateOnMouseOverProperty, value);
        }

        public static readonly DependencyProperty AnimateOnMouseOverProperty =
            DependencyProperty.Register(nameof(AnimateOnMouseOver),
                typeof(bool), typeof(RoundedImage),
                new PropertyMetadata(true));
        #endregion [ANIMATE ON MOUSE OVER]


        static RoundedImage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundedImage), new FrameworkPropertyMetadata(typeof(RoundedImage)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            if (GetTemplateChild("PART_Image") is Image img &&
                GetTemplateChild("RootGrid") is Grid grid &&
                GetTemplateChild("PART_Border") is Border border)
            {
                grid.SizeChanged += (s, e) =>
                {
                    RectangleGeometry Rect = new RectangleGeometry
                    {
                        Rect = new Rect(0, 0, grid.ActualWidth, grid.ActualHeight),
                        RadiusX = CornerRadius.TopLeft + 3,
                        RadiusY = CornerRadius.TopLeft + 3
                    };
                    img.Clip = Rect;
                    grid.Clip = Rect;
                    //border.Clip = Rect;
                };
            }
        }

    }
}
