using System;
using System.Windows;
using System.Windows.Controls;

namespace InnoversUI
{
    public class TextField : TextBox
    {

        // HINT TEXT
        public string HintText
        {
            get { return (string)GetValue(HintTextProperty); }
            set { SetValue(HintTextProperty, value); }
        }

        public static readonly DependencyProperty HintTextProperty =
            DependencyProperty.Register("HintText", typeof(string), typeof(TextField), new PropertyMetadata(string.Empty));


        //IS EMPTY
        public bool IsEmpty
        {
            get { return (bool)GetValue(IsEmptyProperty); }
            private set { SetValue(IsEmptyPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey IsEmptyPropertyKey =
           DependencyProperty.RegisterReadOnly("IsEmpty", typeof(bool), typeof(TextField), new PropertyMetadata(true));

        public static readonly DependencyProperty IsEmptyProperty = IsEmptyPropertyKey.DependencyProperty;


        public bool IsOnlyNumeric
        {
            get { return (bool)GetValue(IsOnlyNumericProperty); }
            private set { SetValue(IsOnlyNumericPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey IsOnlyNumericPropertyKey =
           DependencyProperty.RegisterReadOnly("IsOnlyNumeric", typeof(bool), typeof(TextField), new PropertyMetadata(false));

        public static readonly DependencyProperty IsOnlyNumericProperty = IsOnlyNumericPropertyKey.DependencyProperty;

        static TextField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextField), new FrameworkPropertyMetadata(typeof(TextField)));
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            IsEmpty = string.IsNullOrEmpty(Text);
            Console.WriteLine("LIBRARY USAGE");
            base.OnTextChanged(e);
        }

        //protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        //{
        //    base.OnPreviewTextInput(e);
        //}
    }
}
