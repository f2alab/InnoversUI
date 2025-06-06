using InnoversUI.Dialogs;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace InnoversUI.Utils
{
    public class DialogsUtils
    {
        //DIALOG BACKGROUNG SIZE
        public static void DialogBackgroudSize(Window Parent, Window Child)
        {
            if (Parent != null)
            {
                Child.Width = Parent.ActualWidth;
                Child.MaxWidth = Parent.ActualWidth;
                Child.Height = Parent.ActualHeight;
                Child.MaxHeight = Parent.ActualHeight;
                Child.Top = Parent.Top;
                Child.Left = Parent.Left;
                Child.Owner = Parent;
            }
        }

        public static DialogWait DialogWait(Window Parent, string Message = null)
        {
            DialogWait dialog = new DialogWait(Parent: Parent, Message: Message);
            dialog.Show();
            return dialog;
        }

        public static void ShowDialog(Window Parent, Control Child, bool IsDismissible = false)
        {
            new InnoDialog(Parent: Parent, Child: Child, IsDismissible: IsDismissible).Show();
        }

        public static void CloseDialog()
        {
            foreach (Window window in Application.Current.Windows.OfType<InnoDialog>())
                ((InnoDialog)window).Close();
        }

    }
}
