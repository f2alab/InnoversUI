using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace InnoversUI.Utils
{
    public class AnimationsUtils
    {
        //RUN STORYBOARD
        public static void RunStoryBoard(Control Control, string ResourceKey)
        {
            Storyboard anim = Control.FindResource(ResourceKey) as Storyboard;
            anim.Begin();
        }
    }
}
