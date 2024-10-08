using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InnoversUI
{
    
    public class InnoButton : Button
    {


        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(InnoButton), new PropertyMetadata(new CornerRadius(5)));


        static InnoButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InnoButton), new FrameworkPropertyMetadata(typeof(InnoButton)));
        }
    }
}
