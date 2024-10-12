using System.Windows;
using System.Windows.Controls;

namespace InnoversUI.Controls
{
    
    public class CircleImage : Control
    {
        static CircleImage()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CircleImage), new FrameworkPropertyMetadata(typeof(CircleImage)));
        }
    }
}
