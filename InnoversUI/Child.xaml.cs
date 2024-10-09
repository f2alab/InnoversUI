using InnoversUI.Dialogs;
using InnoversUI.Utils;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace InnoversUI
{
    public partial class Child : UserControl
    {
        public Child()
        {
            InitializeComponent();
        }


        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogsUtils.CloseDialog();
        }
    }
}
