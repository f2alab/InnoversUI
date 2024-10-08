﻿using InnoversUI;
using InnoversUI.Utils;
using System;
using System.Windows;
using System.Windows.Media;

namespace InnoversUITest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextField_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            ControlsUtils.TextBoxOnlyNumericInput(e);
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            WindowUtils.PreventAltF4Close(e, PlaySound: true);
        }

        private void TextField_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
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
            DialogsUtils.ShowDialog(Parent: this, Child: new CircleProgressBar() { ProgressColor = Brushes.White });
        }
    }
}
