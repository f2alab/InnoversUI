using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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

        /// <summary>
        /// Hint text
        /// </summary>
        public string HintText
        {
            get { return (string)GetValue(HintTextProperty); }
            set { SetValue(HintTextProperty, value); }
        }

        public static readonly DependencyProperty HintTextProperty =
            DependencyProperty.Register("HintText", typeof(string), typeof(InnoComboBox), new PropertyMetadata(""));


        public SolidColorBrush HintTextColor
        {
            get { return (SolidColorBrush)GetValue(HintTextColorProperty); }
            set { SetValue(HintTextColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for HintTextColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HintTextColorProperty =
            DependencyProperty.Register("HintTextColor", typeof(SolidColorBrush), typeof(InnoComboBox), new PropertyMetadata(Brushes.Gray));




        public SolidColorBrush ButtonColor
        {
            get { return (SolidColorBrush)GetValue(ButtonColorProperty); }
            set { SetValue(ButtonColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonColorProperty =
            DependencyProperty.Register("ButtonColor", typeof(SolidColorBrush), typeof(InnoComboBox), new PropertyMetadata(Brushes.Teal));




        static InnoComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnoComboBox), new FrameworkPropertyMetadata(typeof(InnoComboBox)));
        }
    }
}
