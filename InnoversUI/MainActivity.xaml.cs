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

        }
    }
}
