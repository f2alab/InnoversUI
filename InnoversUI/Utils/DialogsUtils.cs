using System.Windows;

namespace InnoversUI.Utils
{
    public class DialogsUtils
    {
        //DIALOG BACKGROUNG SIZE
        private static void DialogBackgroudSize(Window Parent, Window Child)
        {
            if (Parent != null)
            {
                Child.Width = Parent.ActualWidth;
                Child.Height = Parent.ActualHeight;
                Child.Top = Parent.Top;
                Child.Left = Parent.Left;
                Child.Owner = Parent;
            }
        }



    }
}
