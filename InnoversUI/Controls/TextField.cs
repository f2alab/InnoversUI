﻿using System;
using System.Windows;
using System.Windows.Controls;
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
        public bool IsEmpty
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
            private set { SetValue(IsOnlyNumericPropertyKey, value); }
        }

        private static readonly DependencyPropertyKey IsOnlyNumericPropertyKey =
           DependencyProperty.RegisterReadOnly("IsOnlyNumeric", typeof(bool), typeof(TextField), new PropertyMetadata(false));

        public static readonly DependencyProperty IsOnlyNumericProperty = IsOnlyNumericPropertyKey.DependencyProperty;
        #endregion [ISONLYNUMERIC]

        static TextField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextField), new FrameworkPropertyMetadata(typeof(TextField)));
        }

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            IsEmpty = string.IsNullOrEmpty(Text);
            base.OnTextChanged(e);
        }
    }
}