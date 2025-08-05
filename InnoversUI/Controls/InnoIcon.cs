using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace InnoversUI.Controls
{
    public class InnoIcon : Control
    {
        

        public SolidColorBrush Fill
        {
            get { return (SolidColorBrush)GetValue(FillProperty); }
            set { SetValue(FillProperty, value); }
        }

        public static readonly DependencyProperty FillProperty =
            DependencyProperty.Register("Fill", typeof(SolidColorBrush), typeof(InnoIcon), new PropertyMetadata(Brushes.Black));



        public Geometry IconData
        {
            get { return (Geometry)GetValue(IconDataProperty); }
            set { SetValue(IconDataProperty, value); }
        }

        public static readonly DependencyProperty IconDataProperty =
            DependencyProperty.Register("IconData", typeof(Geometry), typeof(InnoIcon), new PropertyMetadata(null));

        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(double), typeof(InnoIcon), new PropertyMetadata(24d));




        static InnoIcon()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnoIcon), new FrameworkPropertyMetadata(typeof(InnoIcon)));
           
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.Width = this.Size;
            this.Height = this.Size;
        }
    }
}
