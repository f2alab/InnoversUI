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

        internal InnoDialog(Window Parent, FrameworkElement Child, bool IsDismissible = false)
        {
            InitializeComponent();

            Dismissible = IsDismissible;
            //DIALOG BACKGROUND SIZE
            //if (Parent != null)
            DialogsUtils.DialogBackgroudSize(Parent: Parent, Child: this);


            //ADD CHILD
            Child.MaxHeight = Parent.ActualHeight;
            Child.MinWidth = Parent.ActualWidth;
            Child.HorizontalAlignment = HorizontalAlignment.Center;
            Child.VerticalAlignment = VerticalAlignment.Center;
            MainBorder.Children.Add(Child);

           

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
            if (!Dismissible)
                WindowUtils.PreventAltF4Close(e);
        }

        private void MainBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //POUR DESACTIVER LE CLICKAGE DE BORDER POUR EVITER DE FERMER LE DIALOG EN CAS DE DISMISSIBLE=true
            e.Handled = true;
        }
    }
}
