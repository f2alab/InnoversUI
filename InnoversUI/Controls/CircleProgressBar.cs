using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InnoversUI.Controls
{

    public class CircleProgressBar : Control
    {

        #region [PROPRIETIES]

        public static readonly DependencyProperty SizeProperty =
          DependencyProperty.Register("Size", typeof(double), typeof(CircleProgressBar), new PropertyMetadata(80.0));

        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty ThicknessProperty =
         DependencyProperty.Register("Thickness", typeof(double), typeof(CircleProgressBar), new PropertyMetadata(5.0));

        public double Thickness
        {
            get { return (double)GetValue(ThicknessProperty); }
            set { SetValue(ThicknessProperty, value); }
        }

        public static readonly DependencyProperty IsLoadingProperty =
           DependencyProperty.Register("IsLoading", typeof(bool), typeof(CircleProgressBar), new PropertyMetadata(true));

        public bool IsLoading
        {
            get { return (bool)GetValue(IsLoadingProperty); }
            set { SetValue(IsLoadingProperty, value); }
        }



        public SolidColorBrush ProgressColor
        {
            get { return (SolidColorBrush)GetValue(ProgressColorProperty); }
            set { SetValue(ProgressColorProperty, value); }
        }


       
        public static readonly DependencyProperty ProgressColorProperty =
            DependencyProperty.Register("ProgressColor", typeof(SolidColorBrush), typeof(CircleProgressBar), new PropertyMetadata(Brushes.Black));




        public PenLineCap LineCape
        {
            get { return (PenLineCap)GetValue(LineCapeProperty); }
            set { SetValue(LineCapeProperty, value); }
        }

        
        public static readonly DependencyProperty LineCapeProperty =
            DependencyProperty.Register("LineCape", typeof(PenLineCap), typeof(CircleProgressBar), new PropertyMetadata(PenLineCap.Round));



        #endregion [PROPRIETIES]

        static CircleProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleProgressBar), new FrameworkPropertyMetadata(typeof(CircleProgressBar)));
        }
    }
}
