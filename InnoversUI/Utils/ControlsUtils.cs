using System;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;

namespace InnoversUI.Utils
{
    public class ControlsUtils
    {

        //ONLY NUMERIC TEXTBOX TEXTBOX
        public static bool OnlyNumeric(string Text)
        {
            string RegString = string.Format("[^0-9{0}-]+", Constantes.DECIMALSEPARATOR);
            if (new Regex(RegString).IsMatch(Text))
            {
                SystemSounds.Exclamation.Play();
            }
            return new Regex(RegString).IsMatch(Text);
        }
    }
}
