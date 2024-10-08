using System.Media;
using System.Windows.Input;

namespace InnoversUI.Utils
{
    public class WindowUtils
    {
        //EMPECHER LA FERMERTURE AVEC ALT + F4
        public static void PreventAltF4Close(KeyEventArgs e, bool PlaySound = true)
        {
            if (e.Key == Key.System && e.SystemKey == Key.F4)
            {
                e.Handled = true;
                if (PlaySound)
                    SystemSounds.Exclamation.Play();
            }
        }
    }
}
