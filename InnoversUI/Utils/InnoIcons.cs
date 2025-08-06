using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media;

namespace InnoversUI.Utils
{
    public enum InnoIcons
    {
        Home,
        Localisation,
        Settings,
        Help,
        About,
        Close,
        Maximize,
        Minimize,
        Profil,
        Person,
        People,
        Edit,
        Delete,
        Add,
        ArrowUp,
        ArrowDown,
        ArrowLeft,
        ArrowRight,
        ChevronUp,
        ChevronDown,
        ChevronLeft,
        ChevronRight,
        Checkmark
    }

    public static class InnoIconsData
    {
        private static readonly Dictionary<InnoIcons, Geometry> Icons = new Dictionary<InnoIcons, Geometry>
        {
            { InnoIcons.ArrowUp, Geometry.Parse("M 10,20 L 20,10 L 30,20") },
            { InnoIcons.Localisation, Geometry.Parse("M12,0A10.011,10.011,0,0,0,2,10c0,5.282,8.4,12.533,9.354,13.343l.646.546.646-.546C13.6,22.533,22,15.282,22,10A10.011,10.011,0,0,0,12,0Zm0,15a5,5,0,1,1,5-5A5.006,5.006,0,0,1,12,15Z") },
            { InnoIcons.ArrowUp, Geometry.Parse("M 10,20 L 20,10 L 30,20") },
            { InnoIcons.ArrowDown, Geometry.Parse("M 10,10 L 20,20 L 30,10") },
            { InnoIcons.Checkmark, Geometry.Parse("M 10,20 L 18,28 L 30,10") },
            { InnoIcons.Close, Geometry.Parse("M 10,10 L 30,30 M 30,10 L 10,30") }
        };

        public static Geometry GetGeometry(InnoIcons Kind)
        {
            return Icons.TryGetValue(Kind, out var Geometry) ? Geometry : Geometry.Empty;
        }


        [MarkupExtensionReturnType(typeof(Geometry))]
        public class InnoIconsGeometryExtension : MarkupExtension
        {
            public InnoIcons Kind { get; set; }

            public InnoIconsGeometryExtension() { }

            public InnoIconsGeometryExtension(InnoIcons Kind)
            {
                this.Kind = Kind;
            }

            public override object ProvideValue(IServiceProvider serviceProvider)
            {
                return InnoIconsData.GetGeometry(Kind: Kind);
            }
        }

    }
}
