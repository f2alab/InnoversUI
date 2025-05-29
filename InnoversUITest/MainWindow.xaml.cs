using InnoversUI;
using InnoversUI.Controls;
using InnoversUI.Utils;
using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace InnoversUITest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AnimationsUtils.VerticalSlideAnimation(Element: MainGrid, From: 100, CompletedAction: () => { Console.WriteLine("ANIMATION IS COMPLETED"); });


        }

        

        private void TextField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
           
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            WindowUtils.PreventAltF4Close(e, PlaySound: true);
        }

        private void TextField_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("IsEmpty: " + TF.IsEmpty);
            Console.WriteLine("CALL USAGE");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogsUtils.DialogWait(Parent: this, Message: "En Cours...");
        }

        private void DialogtBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogsUtils.ShowDialog(Parent: this, Child: new CircleProgressBar() { ProgressColor = Brushes.White }, IsDismissible: true);
        }

        private void InnoBtn_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("INNO BUTTON CLICK");
            Console.WriteLine("PASS: " + TextField0.Password);

            //AnimationsUtils.VerticalSlideAnimation(Element: MainGrid, From: 30);
            AnimationsUtils.VerticalSlideAnimation(Element: MainGrid, From: 100,
                CompletedAction: () => { 
                    Console.WriteLine("ANIMATION IS COMPLETED");
                    AnimationsUtils.HorizontalSlideAnimation(Element: MainGrid, From: -100);
                }
            );
        }

        private void DialogWithChildBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogsUtils.ShowDialog(Parent: this, Child: new Child(), IsDismissible: true);
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void CircleImageBtn_Click(object sender, RoutedEventArgs e)
        {
            ImagesUtils.OpenAndDisplayImage(ImageControl: CircleImageBtn);
        }

        private void CBX_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            TextField0.IsPassTextField = false;
        }

        private void CBX_Unchecked(object sender, RoutedEventArgs e)
        {
            TextField0.IsPassTextField = true;
        }

        private void TextField0_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("TF0 TEXT CHANGED");
        }
    }
}
