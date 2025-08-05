using System.Windows;
using System.Windows.Controls;

namespace InnoversUI.Controls
{


    public class InnoComboBox : ComboBox
    {
        /// <summary>
        /// Corner radius of the border
        /// </summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(InnoComboBox), new PropertyMetadata(new CornerRadius(5)));



        /// <summary>
        /// Button icon size
        /// </summary>
        public double IconSize
        {
            get { return (double)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }

        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(double), typeof(InnoComboBox), new PropertyMetadata(20.0));




        static InnoComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnoComboBox), new FrameworkPropertyMetadata(typeof(InnoComboBox)));
        }
    }
}
