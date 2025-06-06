using InnoversUI.Utils;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace InnoversUI.Controls
{

    public class TextField : TextBox
    {

        // HINT TEXT
        #region [HINTTEXT]
        public string HintText
        {
            get { return (string)GetValue(HintTextProperty); }
            set { SetValue(HintTextProperty, value); }
        }

        public static readonly DependencyProperty HintTextProperty =
            DependencyProperty.Register("HintText", typeof(string), typeof(TextField), new PropertyMetadata(string.Empty));

        #endregion [HINTTEXT]

        //HINTTEXT COLOR
        #region [HINTTEXT COLOR]
        public SolidColorBrush HintTextColor
        {
            get { return (SolidColorBrush)GetValue(HintTextColorProperty); }
            set { SetValue(HintTextColorProperty, value); }
        }

        public static readonly DependencyProperty HintTextColorProperty =
            DependencyProperty.Register("HintTextColor", typeof(SolidColorBrush), typeof(TextField), new PropertyMetadata(Brushes.Gray));
        #endregion [HINTTEXT COLOR]

        //HINT TEXT VERTICAL ALIGNMENT
        #region [HINTTEXT VERTICAL ALIGNMENT]
        public VerticalAlignment HintTextVerticalAlignment
        {
            get { return (VerticalAlignment)GetValue(HintTextVerticalAlignmentProperty); }
            set { SetValue(HintTextVerticalAlignmentProperty, value); }
        }

        public static readonly DependencyProperty HintTextVerticalAlignmentProperty =
            DependencyProperty.Register("HintTextVerticalAlignment", typeof(VerticalAlignment), typeof(TextField), new PropertyMetadata(VerticalAlignment.Center));
        #endregion [HINTTEXT VERTICAL ALIGNMENT]

        //HINT TEXT HORIZONTAL ALIGNMENT
        #region [HINTTEXT HORIZONTAL ALIGNMENT]
        public HorizontalAlignment HintTextHorizontalAlignment
        {
            get { return (HorizontalAlignment)GetValue(HintTextHorizontalAlignmentProperty); }
            set { SetValue(HintTextHorizontalAlignmentProperty, value); }
        }


        public static readonly DependencyProperty HintTextHorizontalAlignmentProperty =
            DependencyProperty.Register("HintTextHorizontalAlignment", typeof(HorizontalAlignment), typeof(TextField), new PropertyMetadata(HorizontalAlignment.Left));
        #endregion [HINTTEXT HORIZONTAL ALIGNMENT]

        //HINT TEXT PADDING
        #region [HINTTEXT PADDING]
        public Thickness HintTextPadding
        {
            get { return (Thickness)GetValue(HintTextPaddingProperty); }
            set { SetValue(HintTextPaddingProperty, value); }
        }

        //LEFT ICON
        #region [LEFT ICON]

        public Control LeftIcon
        {
            get { return (Control)GetValue(LeftIconProperty); }
            set { SetValue(LeftIconProperty, value); }
        }


        public static readonly DependencyProperty LeftIconProperty =
            DependencyProperty.Register("LeftIcon", typeof(Control), typeof(TextField), new PropertyMetadata(null));



        public Brush LeftIconBackColor
        {
            get { return (Brush)GetValue(LeftIconBackColorProperty); }
            set { SetValue(LeftIconBackColorProperty, value); }
        }


        public static readonly DependencyProperty LeftIconBackColorProperty =
            DependencyProperty.Register("LeftIconBackColor", typeof(Brush), typeof(TextField), new PropertyMetadata(Brushes.Transparent));




        #endregion [LEFT ICON]

        //RIGHT ICON
        #region [RIGHT ICON]

        public FrameworkElement RightIcon
        {
            get { return (FrameworkElement)GetValue(RightIconProperty); }
            set { SetValue(RightIconProperty, value); }
        }


        public static readonly DependencyProperty RightIconProperty =
            DependencyProperty.Register("RightIcon", typeof(FrameworkElement), typeof(TextField), new PropertyMetadata(null));



        public Brush RightIconBackColor
        {
            get { return (Brush)GetValue(RightIconBackColorProperty); }
            set { SetValue(RightIconBackColorProperty, value); }
        }


        public static readonly DependencyProperty RightIconBackColorProperty =
            DependencyProperty.Register("RightIconBackColor", typeof(Brush), typeof(TextField), new PropertyMetadata(Brushes.Transparent));




        #endregion [RIGHT ICON]

        public static readonly DependencyProperty HintTextPaddingProperty =
            DependencyProperty.Register("HintTextPadding", typeof(Thickness), typeof(TextField), new PropertyMetadata(new Thickness(3)));
        #endregion [HINTTEXT PADDING]

        #region [CORNER RADIUS]
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(TextField), new PropertyMetadata(new CornerRadius(5)));
        #endregion [CORNER RADIUS]
        //IS EMPTY
        #region [ISEMPTY]
        public bool IsEmpty //QUE J'UPDATE DANS OnTextChanged
        {
            get { return (bool)GetValue(IsEmptyProperty); }
            private set { SetValue(IsEmptyPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey IsEmptyPropertyKey =
           DependencyProperty.RegisterReadOnly("IsEmpty", typeof(bool), typeof(TextField), new PropertyMetadata(true));

        public static readonly DependencyProperty IsEmptyProperty = IsEmptyPropertyKey.DependencyProperty;

        #endregion [ISEMPTY]

        //ISONLYNUMERIC
        #region [ISONLYNUMERIC]
        public bool IsOnlyNumeric
        {
            get { return (bool)GetValue(IsOnlyNumericProperty); }
            set { SetValue(IsOnlyNumericProperty, value); }
        }

        public static readonly DependencyProperty IsOnlyNumericProperty =
           DependencyProperty.Register("IsOnlyNumeric", typeof(bool), typeof(TextField), new PropertyMetadata(false));
        #endregion [ISONLYNUMERIC] 

        // IS EMAIL
        #region [IS EMAIL TEXTFIELD]
        public bool IsEmailTextField //QUE J'UPDATE DANS OnTextChanged
        {
            get { return (bool)GetValue(IsEmailTextFieldProperty); }
            set { SetValue(IsEmailTextFieldProperty, value); }
        }

        public static readonly DependencyProperty IsEmailTextFieldProperty =
           DependencyProperty.Register("IsEmailTextField", typeof(bool), typeof(TextField), new PropertyMetadata(false));
        #endregion [IS EMAIL TEXTFIELD]

        //IS PASS TEXTFIELD
        #region [IS PASS TEXTFIELD]
        public bool IsPassTextField //QUE J'UPDATE DANS OnTextChanged
        {
            get { return (bool)GetValue(IsPassTextFieldProperty); }
            set { SetValue(IsPassTextFieldProperty, value); }
        }

        public static readonly DependencyProperty IsPassTextFieldProperty =
           DependencyProperty.Register("IsPassTextField", typeof(bool), typeof(TextField), new PropertyMetadata(false));
        #endregion [IS PASS TEXTFIELD]


        //PASS CHAR
        #region [PASS CHAR]
        public string PasswordChar
        {
            get { return (string)GetValue(PasswordCharProperty); }
            set { SetValue(PasswordCharProperty, value); }
        }


        public static readonly DependencyProperty PasswordCharProperty =
            DependencyProperty.Register("PasswordChar", typeof(string), typeof(TextField), new PropertyMetadata("•"));


        #endregion [PASS CHAR]

        #region [PASSWORD]


        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(TextField), new PropertyMetadata(string.Empty));


        #endregion [PASSWORD]



        #region [PASSWORDBOX]
        static readonly string PassTextBoxString = "PassTextBox";
        //static PasswordBox PassBox;
        #endregion [PASSWORDBOX]

        static TextField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextField), new FrameworkPropertyMetadata(typeof(TextField)));
        }



        public override void OnApplyTemplate()
        {
            PasswordBox PassBox = (PasswordBox)Template.FindName(PassTextBoxString, this);

            PassBox.PasswordChanged += PassBoxPasswordChanged;
            PassBox.FocusableChanged += PassBox_FocusableChanged;
            base.OnApplyTemplate();
        }

        private void PassBox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PasswordBox PassBox = (PasswordBox)Template.FindName(PassTextBoxString, this);
            PassBox.Focusable = IsFocused;
        }

        private void PassBoxPasswordChanged(object sender, RoutedEventArgs e)
        {
            if (IsLoaded)
            {
                string Pass = ((PasswordBox)Template.FindName(PassTextBoxString, this)).Password;
                Text = Pass;

                //CODE POUR QUE LE CURSUER SE AUTOMATIQUEMENT A LA FIN DU PASS
                #region [CODE POUR QUE LE CURSUER SE AUTOMATIQUEMENT A LA FIN DU PASS]
                if (IsPassTextField)
                {
                    var a = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, Key.End)
                    {
                        RoutedEvent = Keyboard.KeyDownEvent
                    };
                    InputManager.Current.ProcessInput(a);
                }
                #endregion [CODE POUR QUE LE CURSUER SE AUTOMATIQUEMENT A LA FIN DU PASS]
            }

        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            //DEFINIR TEXTFIELD IS EMPTY
            IsEmpty = string.IsNullOrEmpty(Text);

            if (IsLoaded)
            {
                //DEFINIR IS EMAIL
                IsEmailTextField = ControlsUtils.IsEmail(Email: Text);

                //DEFINIR PASS DANS PASSTEXTBOX
                if (((PasswordBox)Template.FindName(PassTextBoxString, this)) != null)
                    ((PasswordBox)Template.FindName(PassTextBoxString, this)).Password = Text;
            }

            base.OnTextChanged(e);

        }

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            base.OnPreviewTextInput(e);
            if (IsOnlyNumeric)
            {
                e.Handled = ControlsUtils.OnlyNumeric(Text: e.Text);
            }
        }


    }
}
