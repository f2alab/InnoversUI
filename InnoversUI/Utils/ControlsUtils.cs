using System;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace InnoversUI.Utils
{
    public class ControlsUtils
    {
        public static void TextBoxOnlyNumericInput(TextCompositionEventArgs e)
        {
            Regex regex = new Regex("^\\d+\\.\\d+$");
            e.Handled = regex.IsMatch(e.Text);
            Console.WriteLine("TextBoxOnlyNumericInput");
        }
    }
}
