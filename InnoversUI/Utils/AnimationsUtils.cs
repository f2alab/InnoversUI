using InnoversUI.Properties;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace InnoversUI.Utils
{
    public class AnimationsUtils
    {
        //RUN STORYBOARD
        public static void RunStoryBoard(Control Control, string ResourceKey)
        {
            Storyboard anim = Control.FindResource(ResourceKey) as Storyboard;
            anim.Begin();
        }

        public static void RandomElementAnimation(FrameworkElement Element, double Duration = 0, double FromMargin = 0, double FromOpacity = 0)
        {
            List<Action> Anims = new List<Action>()
            {
                ()=>AnimateElementMarginLeftRight(Element, Duration: Duration, FromMargin: FromMargin),
                ()=>AnimateElementOpacity(Element, Duration: Duration, FromOpacity: FromOpacity),
                ()=>AnimateElementMarginTopBottom(Element, Duration: Duration, FromMargin: FromMargin),
            };

            int Index = new Random().Next(0, Anims.Count);

            Anims[Index].Invoke();
        }

        static readonly double DURATION = 250;
        static readonly double MARGIN = 30;

        public static void AnimateElementMarginLeftRight(FrameworkElement Element, double Duration = 0, double FromMargin = 0)
        {
            ThicknessAnimation Animation = new ThicknessAnimation
            {
                From = new Thickness(FromMargin == 0 ? MARGIN : FromMargin, 0, FromMargin == 0 ? MARGIN : FromMargin, 0),
                To = new Thickness(0),
                Duration = TimeSpan.FromMilliseconds(Duration == 0 ? DURATION : Duration),
            };

            Element.BeginAnimation(FrameworkElement.MarginProperty, Animation);
        }

        public static void AnimateElementMarginTopBottom(FrameworkElement Element, double Duration = 0, double FromMargin = 0)
        {
            ThicknessAnimation Animation = new ThicknessAnimation
            {
                From = new Thickness(0, FromMargin == 0 ? MARGIN : FromMargin, 0, FromMargin == 0 ? MARGIN : FromMargin),
                To = new Thickness(0),
                Duration = TimeSpan.FromMilliseconds(Duration == 0 ? DURATION : Duration)
            };

            Element.BeginAnimation(FrameworkElement.MarginProperty, Animation);

        }

        public static void AnimateElementOpacity(FrameworkElement Element, double Duration = 0, double FromOpacity = 0.3)
        {
            DoubleAnimation Animation = new DoubleAnimation
            {
                From = FromOpacity,
                To = 1,
                Duration = TimeSpan.FromMilliseconds(Duration == 0 ? DURATION : Duration)
            };

            Element.BeginAnimation(UIElement.OpacityProperty, Animation);
        }


        public static void HorizontalSlideAnimation(FrameworkElement Element, double From = -50, double To = 0)
        {
            /// Use negative values to move left to right
            /// and positive values to move right to left
            var translateTransform = new TranslateTransform();
            Element.RenderTransform = translateTransform;
            var animation = new DoubleAnimation
            {
                From = From,
                To = To,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                //AutoReverse = true,
                //RepeatBehavior = RepeatBehavior.Forever
            };
            translateTransform.BeginAnimation(TranslateTransform.XProperty, animation);
        }

        public static void VerticalSlideAnimation(FrameworkElement Element, double From = -50, double To = 0, Action CompletedAction = null)
        {
            /// Use negative values to move up to down
            /// and positive values to move down to up
            var translateTransform = new TranslateTransform();
            Element.RenderTransform = translateTransform;
            var animation = new DoubleAnimation
            {
                From = From,
                To = To,
                Duration = new Duration(TimeSpan.FromSeconds(2)),
                //AutoReverse = true,
                //RepeatBehavior = RepeatBehavior.Forever
            };
            animation.Completed += (s, e) => CompletedAction?.Invoke();
            translateTransform.BeginAnimation(TranslateTransform.YProperty, animation);
        }
    }
}
