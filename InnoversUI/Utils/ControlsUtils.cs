using System.Media;
using System.Text.RegularExpressions;

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

        //EMAIL PATTERN
        public static bool IsEmail(string Email)
        {
            return Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }
    }
}
