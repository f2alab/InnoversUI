using System.Windows;
using System.Windows.Controls;

namespace InnoversUI
{

    public class IconTextField : TextBox
    {

        // HINT TEXT
        public string HintText
        {
            get { return (string)GetValue(HintTextProperty); }
            set { SetValue(HintTextProperty, value); }
        }

        public static readonly DependencyProperty HintTextProperty =
            DependencyProperty.Register("HintText", typeof(string), typeof(IconTextField), new PropertyMetadata(string.Empty));


        //IS EMPTY
        public bool IsEmpty
        {
            get { return (bool)GetValue(IsEmptyProperty); }
            private set { SetValue(IsEmptyPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey IsEmptyPropertyKey =
           DependencyProperty.RegisterReadOnly("IsEmpty", typeof(bool), typeof(IconTextField), new PropertyMetadata(true));

        public static readonly DependencyProperty IsEmptyProperty = IsEmptyPropertyKey.DependencyProperty;

        static IconTextField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconTextField), new FrameworkPropertyMetadata(typeof(IconTextField)));
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            IsEmpty = string.IsNullOrEmpty(Text);
            base.OnTextChanged(e);
        }
    }
}
