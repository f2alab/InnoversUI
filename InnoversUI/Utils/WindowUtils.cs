using System.Media;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

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


        public static Window GetParentWindow(DependencyObject child)
        {
            DependencyObject parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null)
            {
                return null;
            }

            Window parent = parentObject as Window;
            if (parent != null)
            {
                return parent;
            }
            else
            {
                return GetParentWindow(parentObject);
            }
        }
    }
}
