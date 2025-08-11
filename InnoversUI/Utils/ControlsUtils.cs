using System.Media;
using System.Text.RegularExpressions;
using System.Windows;

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

        //CALCULER HAUTEUR/WIDTH D'UN ELEMENT COLLAPSEED
        public static double CollapseControlWidth(FrameworkElement Element)
        {
            Element.Measure(new Size(Element.MaxWidth, Element.MaxHeight));
            return Element.DesiredSize.Width;
        }

        public static double CollapseControlHeight(FrameworkElement Element)
        {
            Element.Measure(new Size(Element.MaxWidth, Element.MaxHeight));
            return Element.DesiredSize.Height;
        }
        public static Size CollapseControlSize(FrameworkElement Element)
        {
            Element.Measure(new Size(Element.MaxWidth, Element.MaxHeight));
            return new Size(width: Element.DesiredSize.Width, height: Element.DesiredSize.Height);
        }
    }
}
