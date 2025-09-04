using System;
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
            DependencyProperty.Register("Size", typeof(double), typeof(CircleImage), new PropertyMetadata(80.0));
        #endregion [SIZE]

        //IMAGE SOURCE
        #region [IMAGE SOURCE]
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CircleImage), new PropertyMetadata(null));
        #endregion [IMAGE SOURCE]

        //IMAGE STRETCH
        #region [IMAGE STRETCH]
        public Stretch Stretch
        {
            get { return (Stretch)GetValue(StretchProperty); }
            set { SetValue(StretchProperty, value); }
        }

        public static readonly DependencyProperty StretchProperty =
            DependencyProperty.Register("Stretch", typeof(Stretch), typeof(CircleImage), new PropertyMetadata(Stretch.UniformToFill));
        #endregion [IMAGE STRETCH]

        //BORDER COLOR 
        #region [BORDER COLOR]
        public Brush BorderColor
        {
            get { return (Brush)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly DependencyProperty BorderColorProperty =
            DependencyProperty.Register("BorderColor", typeof(Brush), typeof(CircleImage), new PropertyMetadata(Brushes.Gray));
        #endregion [BORDER COLOR]

        #region [BORDER THICKNESS]


        public double BorderWidth
        {
            get { return (double)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static readonly DependencyProperty BorderWidthProperty =
            DependencyProperty.Register("BorderWidth", typeof(double), typeof(CircleImage), new PropertyMetadata(0d));


        #endregion [BORDER THICKNESS]

        #region [IS CLICKABLE]
        public bool IsClickable
        {
            get => (bool)GetValue(IsClickableProperty);
            set => SetValue(IsClickableProperty, value);
        }
        public static readonly DependencyProperty IsClickableProperty =
        DependencyProperty.Register(nameof(IsClickable), typeof(bool), typeof(CircleImage), new PropertyMetadata(false));

        #endregion [IS CLICKABLE]

        #region [SPLASH COLOR]
        public Brush SplashColor
        {
            get => (Brush)GetValue(SplashColorProperty);
            set => SetValue(SplashColorProperty, value);
        }
        public static readonly DependencyProperty SplashColorProperty =
        DependencyProperty.Register(nameof(SplashColor), typeof(Brush), typeof(CircleImage), new PropertyMetadata(Brushes.LightGray));

        #endregion [SPLASH COLOR]

        #region [SPLASH OPACITY]
        //public double SplashOpacity
        //{
        //    get => (double)GetValue(SplashOpacityProperty);
        //    set => SetValue(SplashOpacityProperty, value);
        //}
        //public static readonly DependencyProperty SplashOpacityProperty =
        //DependencyProperty.Register(nameof(SplashOpacity), typeof(double), typeof(CircleImage),new PropertyMetadata(0.5));

        #endregion [SPLASH OPACITY]

        static CircleImage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleImage), new FrameworkPropertyMetadata(typeof(CircleImage)));
        }

        
        private Grid _root;
        private EllipseGeometry _clip;

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            _root = GetTemplateChild("RootGrid") as Grid;

            if (_root != null)
            {
                _clip = new EllipseGeometry();
                _root.Clip = _clip;

                _root.SizeChanged += (s, e) =>
                {
                    double size = Math.Min(_root.ActualWidth, _root.ActualHeight);
                    double radius = size / 2;

                    // ✅ Centrage sur le conteneur (pas sur l’image)
                    _clip.Center = new Point(_root.ActualWidth / 2, _root.ActualHeight / 2);
                    _clip.RadiusX = radius;
                    _clip.RadiusY = radius;
                };
            }
        }
    }
}
