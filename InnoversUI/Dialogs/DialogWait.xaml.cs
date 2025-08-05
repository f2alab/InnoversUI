using InnoversUI.Utils;
using System.Media;
using System.Windows;
using System.Windows.Input;

namespace InnoversUI.Dialogs
{
    public partial class DialogWait : Window
    {
        internal DialogWait()
        {
            InitializeComponent();
        }

        internal DialogWait(Window Parent, string Message = null)
        {
            InitializeComponent();

            //DIALOG BACKGROUND SIZE
            //if (Parent != null)
            DialogsUtils.DialogBackgroudSize(Parent: Parent, Child: this);

            if (Message != null)
            {
                MessageTextBlock.Visibility = Visibility.Visible;
                MessageTextBlock.Text = Message;
            }
            else
            {
                MessageTextBlock.Visibility = Visibility.Collapsed;
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            SystemSounds.Exclamation.Play();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            //EMPECHER LA FERMERTURE AVEC ALT + F4
            WindowUtils.PreventAltF4Close(e);
        }
    }
}
