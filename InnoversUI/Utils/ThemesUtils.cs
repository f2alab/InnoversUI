using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InnoversUI.Utils
{
    public class ThemesUtils
    {
        public enum Theme { Light, Dark };

        public static void SetTheme(Theme Theme)
        {
            ApplyTheme(Theme);
        }

        internal static void ApplyTheme(Theme Theme)
        {
            try
            {
                string themeName = Theme == Theme.Light ? "Light" : "Dark";
                string themePath = $"/InnoversUI;component/Themes/{themeName}/Theme.xaml";
                var newTheme = new ResourceDictionary { Source = new Uri(themePath, UriKind.RelativeOrAbsolute) };

                var appResources = Application.Current.Resources.MergedDictionaries;
                if(appResources.Count > 0)
                {
                    ResourceDictionary Dic = appResources[0];
                    Console.WriteLine("TRESOURCE SOURCE: " + Dic.Source.OriginalString);
                    Console.WriteLine("TRESOURCE SOURCE: " + Dic.MergedDictionaries[0].Source.OriginalString);
                }

               Console.WriteLine("THEMES COUNT: " + appResources.Count);
                //// Retirer un éventuel thème précédent
                //var existingTheme = appResources.FirstOrDefault(d =>
                //    d.Source != null &&
                //    (d.Source.OriginalString.Contains("Light/Theme.xaml") ||
                //     d.Source.OriginalString.Contains("Dark/Theme.xaml")));

                //if (existingTheme != null)
                //    appResources.Remove(existingTheme);

                //// Ajouter le nouveau
                //appResources.Add(newTheme);
            }
            catch (Exception Ex)
            {
                MessageBox.Show($"Une erreur est survenue lors du chargement du thème: {Ex.Message}");
            }
        }
    }
}
