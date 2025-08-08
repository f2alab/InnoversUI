using System;
using System.Windows;
using System.Windows.Controls;

namespace InnoversUI
{
    public partial class MainActivity : Window
    {
        public MainActivity()
        {
            InitializeComponent();



        }

        private void TF0_TextChanged(object sender, TextChangedEventArgs e)
        {
            Console.WriteLine("TF0 TEXT CHANGED");
        }

        private void Switch_Checked(object sender, RoutedEventArgs e)
        {
            Switch1.Content = "On";
            Switch1.IsEnabled = true;
        }

        private void Switch_Unchecked(object sender, RoutedEventArgs e)
        {
            Switch1.Content = "Off";
            Switch1.IsEnabled = false;
        }

        private void Switch1_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
