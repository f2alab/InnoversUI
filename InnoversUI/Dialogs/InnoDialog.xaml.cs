using InnoversUI.Utils;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace InnoversUI.Dialogs
{
    public partial class InnoDialog : Window
    {
        readonly bool Dismissible;

        internal InnoDialog()
        {
            InitializeComponent();
        }

        public InnoDialog(Window Parent, Control Child, bool IsDismissible = false)
        {
            InitializeComponent();

            Dismissible = IsDismissible;
            //DIALOG BACKGROUND SIZE
            if (Parent != null)
                DialogsUtils.DialogBackgroudSize(Parent: Parent, Child: this);

            //ADD CHILD
            MainBorder.Child = Child;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!Dismissible)
            {
                SystemSounds.Exclamation.Play();
            }
            else
            {
                Close();
            }

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //EMPECHER LA FERMERTURE AVEC ALT + F4
            WindowUtils.PreventAltF4Close(e);
        }
    }
}
