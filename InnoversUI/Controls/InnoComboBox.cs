using System.Windows;
using System.Windows.Controls;

namespace InnoversUI.Controls
{


    public class InnoComboBox : ComboBox
    {
        static InnoComboBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnoComboBox), new FrameworkPropertyMetadata(typeof(InnoComboBox)));
        }
    }
}
