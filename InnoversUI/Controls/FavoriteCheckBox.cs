using InnoversUI.Utils;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace InnoversUI.Controls
{

    public class FavoriteCheckBox : CheckBox
    {
        //SIZE
        #region [SIZE]
        public double Size
        {
            get { return (double)GetValue(SizeProperty); }
            set { SetValue(SizeProperty, value); }
        }

        public static readonly DependencyProperty SizeProperty =
            DependencyProperty.Register("Size", typeof(double), typeof(FavoriteCheckBox), new PropertyMetadata(24.0));
        #endregion [SIZE]





        //public SolidColorBrush ActiveColor
        //{
        //    get { return (SolidColorBrush)GetValue(ActiveColorProperty); }
        //    set { SetValue(ActiveColorProperty, value); }
        //}

        //// Using a DependencyProperty as the backing store for ActiveColor.  This enables animation, styling, binding, etc...
        //public static readonly DependencyProperty ActiveColorProperty =
        //    DependencyProperty.Register("ActiveColor", typeof(SolidColorBrush), typeof(FavoriteCheckBox), new PropertyMetadata(ColorsUtils.ColorFromHex("#FFC107")));




        static FavoriteCheckBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FavoriteCheckBox), new FrameworkPropertyMetadata(typeof(FavoriteCheckBox)));
        }


        static readonly string MainBorderName = "MainGrid";
        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            this.Width = this.Size;
            this.Height = this.Size;

            Grid MainGrid = (Grid)Template.FindName(MainBorderName, this);


            Storyboard ActivateAnimation = (Storyboard)MainGrid.FindResource(resourceKey: "ActiveAnimation");
            Storyboard DesactivateAnimation = (Storyboard)MainGrid.FindResource(resourceKey: "DesactiveAnimation");

            if (ActivateAnimation != null)
            {
                Console.WriteLine("ACTIVATE ANIMATION IS NOT NULL");
                if (IsChecked == true)
                {
                    MainGrid.BeginStoryboard(ActivateAnimation);
                }
                else
                {
                    MainGrid.BeginStoryboard(DesactivateAnimation);
                }
            }
            else
            {
                Console.WriteLine("ACTIVATE ANIMATION IS NULL");
            }
        }
    }
}
