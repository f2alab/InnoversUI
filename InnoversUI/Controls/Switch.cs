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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InnoversUI.Controls
{
    /// <summary>
    /// Suivez les étapes 1a ou 1b puis 2 pour utiliser ce contrôle personnalisé dans un fichier XAML.
    ///
    /// Étape 1a) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans le projet actif.
    /// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
    /// être utilisé :
    ///
    ///     xmlns:MyNamespace="clr-namespace:InnoversUI.Controls"
    ///
    ///
    /// Étape 1b) Utilisation de ce contrôle personnalisé dans un fichier XAML qui existe dans un autre projet.
    /// Ajoutez cet attribut XmlNamespace à l'élément racine du fichier de balisage où il doit 
    /// être utilisé :
    ///
    ///     xmlns:MyNamespace="clr-namespace:InnoversUI.Controls;assembly=InnoversUI.Controls"
    ///
    /// Vous devrez également ajouter une référence du projet contenant le fichier XAML
    /// à ce projet et regénérer pour éviter des erreurs de compilation :
    ///
    ///     Cliquez avec le bouton droit sur le projet cible dans l'Explorateur de solutions, puis sur
    ///     "Ajouter une référence"->"Projets"->[Recherchez et sélectionnez ce projet]
    ///
    ///
    /// Étape 2)
    /// Utilisez à présent votre contrôle dans le fichier XAML.
    ///
    ///     <MyNamespace:Switch/>
    ///
    /// </summary>
    public class Switch : CheckBox
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(Switch), new PropertyMetadata(new CornerRadius(8)));






        public Visibility ThemeIconVisibility
        {
            get { return (Visibility)GetValue(ThemeIconVisibilityProperty); }
            set { SetValue(ThemeIconVisibilityProperty, value); }
        }
        public static readonly DependencyProperty ThemeIconVisibilityProperty =
            DependencyProperty.Register("ThemeIconVisibility", typeof(Visibility), typeof(Switch), new PropertyMetadata(Visibility.Collapsed));





        static readonly string MainBorderName= "MainBorder";

        static Switch()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(Switch), new FrameworkPropertyMetadata(typeof(Switch)));
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();

            
            Border MainBorder = (Border)Template.FindName(MainBorderName, this);
           

            Storyboard ActivateAnimation = (Storyboard) MainBorder.FindResource(resourceKey: "ActiveAnimation");
            Storyboard DesactivateAnimation = (Storyboard) MainBorder.FindResource(resourceKey: "DesactiveAnimation");
            
            if(ActivateAnimation != null)
            {
                Console.WriteLine("ACTIVATE ANIMATION IS NOT NULL");
                if (IsChecked == true)
                {
                    MainBorder.BeginStoryboard(ActivateAnimation);
                }
                else
                {
                    MainBorder.BeginStoryboard(DesactivateAnimation);
                }
            }
            else
            {
                Console.WriteLine("ACTIVATE ANIMATION IS NULL");
            }


        }
    }
}
