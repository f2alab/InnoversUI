﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace InnoversUI.Controls
{
    public class ExpanderTile : ContentControl
    {
        static readonly Geometry ChevronDown = Geometry.Parse("M 7.41 8.58 L 12 13.17 L 16.59 8.58 L 18 10 L 12 16 L 6 10 L 7.41 8.58 Z");
        static readonly Geometry ChevronUp = Geometry.Parse("M 7.41 15.41 L 12 10.83 L 16.59 15.41 L 18 14 L 12 8 L 6 14 L 7.41 15.41 Z");

        #region [PROPRETIES]
        //TITLE
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(ExpanderTile), new PropertyMetadata(""));

        //TITLE FONTSIZE

        public double TitleFontSize
        {
            get { return (double)GetValue(TitleFontSizeProperty); }
            set { SetValue(TitleFontSizeProperty, value); }
        }


        public static readonly DependencyProperty TitleFontSizeProperty =
            DependencyProperty.Register("TitleFontSize", typeof(double), typeof(ExpanderTile), new PropertyMetadata(12d));

        //TITLE FORGROUND
        public SolidColorBrush TitleColor
        {
            get { return (SolidColorBrush)GetValue(TitleColorProperty); }
            set { SetValue(TitleColorProperty, value); }
        }

        public static readonly DependencyProperty TitleColorProperty =
            DependencyProperty.Register("TitleColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.Black));


        //ICON
        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(ExpanderTile), new PropertyMetadata(ChevronDown));


        //ICON SIZE

        public double IconSize
        {
            get { return (double)GetValue(IconSizeProperty); }
            set { SetValue(IconSizeProperty, value); }
        }

        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register("IconSize", typeof(double), typeof(ExpanderTile), new PropertyMetadata(20d));



        //ICON COLOR
        public SolidColorBrush IconColor
        {
            get { return (SolidColorBrush)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }

        public static readonly DependencyProperty IconColorProperty =
            DependencyProperty.Register("IconColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.Black));


        //DISPLAY ICON
        public bool ShowIcon
        {
            get { return (bool)GetValue(ShowIconProperty); }
            set { SetValue(ShowIconProperty, value); }
        }

        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.Register("ShowIcon", typeof(bool), typeof(ExpanderTile), new PropertyMetadata(true));



        //LEFT ICON
        public object LeftIcon
        {
            get { return (object)GetValue(LeftIconProperty); }
            set { SetValue(LeftIconProperty, value); }
        }


        public static readonly DependencyProperty LeftIconProperty =
            DependencyProperty.Register("LeftIcon", typeof(object), typeof(ExpanderTile), new PropertyMetadata(null));



        //HEADER HEIGHT
        public double HeaderHeight
        {
            get { return (double)GetValue(HeaderHeightProperty); }
            set { SetValue(HeaderHeightProperty, value); }
        }


        public static readonly DependencyProperty HeaderHeightProperty =
            DependencyProperty.Register("HeaderHeight", typeof(double), typeof(ExpanderTile), new PropertyMetadata(30d));


        //HEADER BACKGROUND COLOR
        public SolidColorBrush HeaderBackgroundColor
        {
            get { return (SolidColorBrush)GetValue(HeaderBackgroundColorProperty); }
            set { SetValue(HeaderBackgroundColorProperty, value); }
        }

        public static readonly DependencyProperty HeaderBackgroundColorProperty =
            DependencyProperty.Register("HeaderBackgroundColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.Transparent));

        //HEADER MOUSE OVER COLOR


        public SolidColorBrush HeaderMouseOverColor
        {
            get { return (SolidColorBrush)GetValue(HeaderMouseOverColorProperty); }
            set { SetValue(HeaderMouseOverColorProperty, value); }
        }

        public static readonly DependencyProperty HeaderMouseOverColorProperty =
            DependencyProperty.Register("HeaderMouseOverColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.LightGray));



        //HEADER BORDER THICKNESS
        public Thickness HeaderBorderThickness
        {
            get { return (Thickness)GetValue(HeaderBorderProperty); }
            set { SetValue(HeaderBorderProperty, value); }
        }


        public static readonly DependencyProperty HeaderBorderProperty =
            DependencyProperty.Register("HeaderBorderThickness", typeof(Thickness), typeof(ExpanderTile), new PropertyMetadata(new Thickness(0)));



        //HEADER CORNER RADIUS
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(ExpanderTile), new PropertyMetadata(new CornerRadius(0)));


        //HEADER BORDER COLOR
        public SolidColorBrush HeaderBorderColor
        {
            get { return (SolidColorBrush)GetValue(HeaderBorderColorProperty); }
            set { SetValue(HeaderBorderColorProperty, value); }
        }

        public static readonly DependencyProperty HeaderBorderColorProperty =
            DependencyProperty.Register("HeaderBorderColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.LightGray));


        //MAIN BORDER

        //BACKCOLOR


        public SolidColorBrush BackColor
        {
            get { return (SolidColorBrush)GetValue(BackColorProperty); }
            set { SetValue(BackColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for BackColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty BackColorProperty =
            DependencyProperty.Register("BackColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.Transparent));



        //BORDER THICKNESS
        public Thickness BorderWidth
        {
            get { return (Thickness)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        public static readonly DependencyProperty BorderWidthProperty =
            DependencyProperty.Register("BorderWidth", typeof(Thickness), typeof(ExpanderTile), new PropertyMetadata(new Thickness(0)));

        // BORDER COLOR


        public SolidColorBrush BorderColor
        {
            get { return (SolidColorBrush)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly DependencyProperty BorderColorProperty =
            DependencyProperty.Register("BorderColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.Black));


        //SEPARATOR
        public bool ShowSeparator
        {
            get { return (bool)GetValue(ShowSeparatorProperty); }
            set { SetValue(ShowSeparatorProperty, value); }
        }

        public static readonly DependencyProperty ShowSeparatorProperty =
            DependencyProperty.Register("ShowSeparator", typeof(bool), typeof(ExpanderTile), new PropertyMetadata(false));

        //SEPARATOR WIDTH
        public double SeparatorHeight
        {
            get { return (double)GetValue(SeparatorHeightProperty); }
            set { SetValue(SeparatorHeightProperty, value); }
        }

        public static readonly DependencyProperty SeparatorHeightProperty =
            DependencyProperty.Register("SeparatorHeight", typeof(double), typeof(ExpanderTile), new PropertyMetadata(1d));


        //SEPARATOR COLOR

        public SolidColorBrush SeparatorColor
        {
            get { return (SolidColorBrush)GetValue(SeparatorColorProperty); }
            set { SetValue(SeparatorColorProperty, value); }
        }

        public static readonly DependencyProperty SeparatorColorProperty =
            DependencyProperty.Register("SeparatorColor", typeof(SolidColorBrush), typeof(ExpanderTile), new PropertyMetadata(Brushes.Black));



        //SEPARATOR MARGIN
        public Thickness SeparatorMargin
        {
            get { return (Thickness)GetValue(SeparatorMarginProperty); }
            set { SetValue(SeparatorMarginProperty, value); }
        }

        public static readonly DependencyProperty SeparatorMarginProperty =
            DependencyProperty.Register("SeparatorMargin", typeof(Thickness), typeof(ExpanderTile), new PropertyMetadata(new Thickness(0)));



        //CHILD
        public object Child
        {
            get { return (object)GetValue(ChildProperty); }
            set { SetValue(ChildProperty, value); }
        }
        public static readonly DependencyProperty ChildProperty =
            DependencyProperty.Register("Child", typeof(object), typeof(ExpanderTile), new PropertyMetadata(null));


        //STATE CAN CHANGE
        public bool StateCanChange
        {
            get { return (bool)GetValue(StateCanChangeProperty); }
            set { SetValue(StateCanChangeProperty, value); }
        }

        public static readonly DependencyProperty StateCanChangeProperty =
            DependencyProperty.Register("StateCanChange", typeof(bool), typeof(ExpanderTile), new PropertyMetadata(true));



        //IS EXPANDED
        public bool IsExpanded
        {
            get { return (bool)GetValue(IsExpandedProperty); }
            set
            { SetValue(IsExpandedProperty, value); }
        }

        public static readonly DependencyProperty IsExpandedProperty =
            DependencyProperty.Register("IsExpanded", typeof(bool), typeof(ExpanderTile), new PropertyMetadata(defaultValue: false, propertyChangedCallback: OnIsExpandedChanged));


        //ISEXPADED CALLBACK
        private static void OnIsExpandedChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is ExpanderTile Expander)
            {
                Expander.OnIsExpandedChanged();
            }
        }

        private void OnIsExpandedChanged()
        {
            if (IsExpanded)
            {
                Icon = ChevronUp;
            }
            else
            {
                Icon = ChevronDown;
            }
        }


        //ANIMATION DURATION


        public double AnimationDuration
        {
            get { return (double)GetValue(AnimationDurationProperty); }
            set { SetValue(AnimationDurationProperty, value); }
        }

        public static readonly DependencyProperty AnimationDurationProperty =
            DependencyProperty.Register("AnimationDuration", typeof(double), typeof(ExpanderTile), new PropertyMetadata(300d));

        #endregion [PROPRETIES]

        static ExpanderTile()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ExpanderTile), new FrameworkPropertyMetadata(typeof(ExpanderTile)));


        }

        static readonly string HeaderToggleButtonIdString = "HeaderToggleButton";

        public override void OnApplyTemplate()
        {
            ToggleButton HeaderToggleButton = (ToggleButton)Template.FindName(HeaderToggleButtonIdString, this);
            HeaderToggleButton.Checked += HeaderToggleButton_Checked;
            HeaderToggleButton.Unchecked += HeaderToggleButton_Unchecked;
            Console.WriteLine($"ChangeHeL.aderCornerRadius TOO {IsExpanded}");

            base.OnApplyTemplate();
        }

        private void HeaderToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!StateCanChange)
            {
                return;
            }
            OpenAnimation(OnAnimationEnd: () => { IsExpanded = !IsExpanded; });
        }

        private void HeaderToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            if (!StateCanChange)
            {
                return;
            }
            OpenAnimation(OnAnimationEnd: () => { IsExpanded = !IsExpanded; });
        }

        private ContentPresenter ContentPresenterContainer => (ContentPresenter)Template.FindName("ContentContainer", this);
        private double ContentContainerHeight = 0;
        private void OpenAnimation(Action OnAnimationEnd)
        {
            ContentPresenter ContentContainer = ContentPresenterContainer;
            if (ContentContainer != null)
            {
                if (IsExpanded)
                {
                    Console.WriteLine("IS EXPANDED ANIMATION");
                    ContentContainerHeight = ContentPresenterContainer.ActualHeight;
                    AnimateElementHeight(Element: ContentContainer, Duration: AnimationDuration, FromHeight: ContentContainer.ActualHeight, ToHeight: 0, OnAnimationEnd: OnAnimationEnd);
                }
                else
                {
                    Console.WriteLine("IS NOT EXPANDED ANIMATION");
                    IsExpanded = true; // IsExpanded = true et non IsExpanded = !IsExpanded (dans OnAnimationEnd), pour forcer l'animation
                    AnimateElementHeight(Element: ContentContainer, Duration: AnimationDuration, FromHeight: 0, ToHeight: ContentContainerHeight);
                }
            }
        }



        private static void AnimateElementHeight(FrameworkElement Element, double Duration = 250, double FromHeight = 0, double ToHeight = 0, Action OnAnimationEnd = null)
        {
            DoubleAnimation Animation = new DoubleAnimation
            {
                From = FromHeight,
                To = ToHeight,
                Duration = TimeSpan.FromMilliseconds(Duration),

            };

            Animation.Completed += (s, e) => OnAnimationEnd?.Invoke();

            Element.BeginAnimation(FrameworkElement.HeightProperty, Animation);
        }

    }
}
