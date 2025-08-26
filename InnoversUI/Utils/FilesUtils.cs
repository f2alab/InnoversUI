using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoversUI.Utils
{
    public class FilesUtils
    {
        public static void MasquerDossierFichier(string Path)
        {
            File.SetAttributes(Path, File.GetAttributes(Path) | FileAttributes.System | FileAttributes.Hidden);
        }

        public static void AfficherDossierFichier(string Path)
        {
            //File.SetAttributes(Path, File.GetAttributes(Path) | ~FileAttributes.System | ~FileAttributes.Hidden);
            FileAttributes attr = File.GetAttributes(Path);
            attr &= FileAttributes.Hidden;
            attr &= ~FileAttributes.System;
            File.SetAttributes(Path, attr);
        }

        public static void OuvrirDossier(string Path)
        {
            System.Diagnostics.Process.Start("explorer.exe", Path);
        }
    }
}
