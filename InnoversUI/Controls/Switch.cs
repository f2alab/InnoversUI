using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace InnoversUI.Controls
{
    public class Switch : CheckBox
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Switch), new PropertyMetadata(new CornerRadius(8)));


        public Visibility ThemeIconVisibility
        {
            get { return (Visibility)GetValue(ThemeIconVisibilityProperty); }
            set { SetValue(ThemeIconVisibilityProperty, value); }
        }
        public static readonly DependencyProperty ThemeIconVisibilityProperty =
            DependencyProperty.Register("ThemeIconVisibility", typeof(Visibility), typeof(Switch), new PropertyMetadata(Visibility.Collapsed));


        public Thickness ContentMargin
        {
            get { return (Thickness)GetValue(ContentMarginProperty); }
            set { SetValue(ContentMarginProperty, value); }
        }

        public static readonly DependencyProperty ContentMarginProperty =
            DependencyProperty.Register("ContentMargin", typeof(Thickness), typeof(Switch), new PropertyMetadata(new Thickness(3, 0, 0, 0)));


        //public Color ActiveBorderColor
        //{
        //    get { return (Color)GetValue(ActiveBorderColorProperty); }
        //    set { SetValue(ActiveBorderColorProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for ActiveBorderColor.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ActiveBorderColorProperty =
        //    DependencyProperty.Register("ActiveBorderColor", typeof(Color), typeof(Switch), new PropertyMetadata(Colors.Blue));

        //public Color InactiveBorderColor
        //{
        //    get { return (Color)GetValue(InactiveBorderColorProperty); }
        //    set { SetValue(InactiveBorderColorProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for ActiveBorderColor.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty InactiveBorderColorProperty =
        //    DependencyProperty.Register("InactiveBorderColor", typeof(Color), typeof(Switch), new PropertyMetadata(Colors.Gray));


        static Switch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(typeof(Switch)));
        }


        //static readonly string MainBorderName = "SwitchTrack";
        //static readonly string CircleName = "Circle";
        //static readonly string ContentName = "Content";
        //static readonly string LightIconName = "LightIcon";
        //static readonly string DarkIconName = "DarkIcon";
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            
            //Border MainBorder = (Border)Template.FindName(MainBorderName, this);
            //Border Circle = (Border)Template.FindName(CircleName, this);
            //ContentPresenter ContentPresenter = (ContentPresenter)Template.FindName(ContentName, this);
           

            //Storyboard ActivateAnimation = (Storyboard) MainBorder.FindResource(resourceKey: "ActiveAnimation");
            //Storyboard DesactivateAnimation = (Storyboard) MainBorder.FindResource(resourceKey: "InactiveAnimation");
            ////Color ActivateBorderBackColor = (Color) MainBorder.FindResource(resourceKey: "ActiveBorderBackColor");
            ////Color ActivateColor = (Color) MainBorder.FindResource(resourceKey: "ActivateColor");
            ////Color DesactivateColor = (Color) MainBorder.FindResource(resourceKey: "DesactivateColor");
            //Thickness ActivateMargin = (Thickness) MainBorder.FindResource(resourceKey: "ActivateMargin");
            //Thickness InactivateMargin = (Thickness) MainBorder.FindResource(resourceKey: "DesactivateMargin");

            //InnoIcon LightIcon = (InnoIcon)Template.FindName(LightIconName, this);
            //InnoIcon DarkIcon = (InnoIcon)Template.FindName(DarkIconName, this);

            //if(IsChecked == true)
            //{
            //    LightIcon.Visibility = Visibility.Collapsed;
            //    DarkIcon.Visibility = Visibility.Visible;
            //}
            //else
            //{
            //    LightIcon.Visibility = Visibility.Visible;
            //    DarkIcon.Visibility = Visibility.Collapsed;
            //}
            

            //if (IsEnabled == false)
            //{
            //    MainBorder.Background = Brushes.Transparent;
            //    MainBorder.BorderBrush = Brushes.Silver;
            //    Circle.Background = Brushes.Silver;

            //    if (IsChecked == false)
            //    {
            //        Circle.Margin = InactivateMargin;
            //    }
            //    else
            //    {
            //        //MainBorder.BeginStoryboard(ActivateAnimation);
            //        Circle.Margin = ActivateMargin;
            //    }
            //}
            //else
            //{
            //    //ANIMATION
            //    // NE LANCER LE STORYBOARD QUE SI L'ANIMATION N'EST PAS NULL ET IsEnabled == true
            //    if (ActivateAnimation != null)
            //    {
            //        Console.WriteLine("ACTIVATE ANIMATION IS NOT NULL");
            //        if (IsChecked == true)
            //        {
            //            MainBorder.BeginStoryboard(ActivateAnimation);
            //        }
            //        else
            //        {
            //            MainBorder.BeginStoryboard(DesactivateAnimation);
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("ACTIVATE ANIMATION IS NULL");
            //    }
            //}


            //if (Content != null && !(Content is string))
            //{
            //    throw new Exception("Content must be a string");
            //}

            ////SHOW OR HIDE TITLE
            
            //if(Content != null)
            //{
            //    string Title = (string)Content;

            //    if (string.IsNullOrWhiteSpace(Title))
            //    {
            //        ContentPresenter.Visibility = Visibility.Collapsed;
            //    }
            //    else
            //    {
            //        ContentPresenter.Visibility = Visibility.Visible;
            //    }
            //}

            


        }

       
    }
}
