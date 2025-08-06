using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
        

        static Switch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(typeof(Switch)));
        }


        static readonly string MainBorderName = "MainBorder";
        static readonly string ContentName = "Content";
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            
            Border MainBorder = (Border)Template.FindName(MainBorderName, this);
            ContentPresenter ContentPresenter = (ContentPresenter)Template.FindName(ContentName, this);
           

            Storyboard ActivateAnimation = (Storyboard) MainBorder.FindResource(resourceKey: "ActiveAnimation");
            Storyboard DesactivateAnimation = (Storyboard) MainBorder.FindResource(resourceKey: "DesactiveAnimation");
            
            //ANIMATION
            if(ActivateAnimation != null)
            {
                Console.WriteLine("ACTIVATE ANIMATION IS NOT NULL");
                if (IsChecked == true)
                {
                    MainBorder.BeginStoryboard(ActivateAnimation);
                }
                else
                {
                    MainBorder.BeginStoryboard(DesactivateAnimation);
                }
            }
            else
            {
                Console.WriteLine("ACTIVATE ANIMATION IS NULL");
            }


            if (Content != null && !(Content is string))
            {
                throw new Exception("Content must be a string");
            }

            //SHOW OR HIDE TITLE
            
            if(Content != null)
            {
                string Title = (string)Content;

                if (string.IsNullOrWhiteSpace(Title))
                {
                    ContentPresenter.Visibility = Visibility.Collapsed;
                }
                else
                {
                    ContentPresenter.Visibility = Visibility.Visible;
                }
            }

            


        }
    }
}
