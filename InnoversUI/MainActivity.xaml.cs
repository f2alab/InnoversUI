using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
    }
}
