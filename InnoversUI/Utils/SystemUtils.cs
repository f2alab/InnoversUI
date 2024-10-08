using System.Windows;
using static InnoversUI.Utilities.Enums;

namespace InnoversUI.Utilities
{
    public class SystemUtils
    {
        //TASKBAR POSITION
        public static TaskBarLocation TaskBarPosition()
        {
            if (SystemParameters.WorkArea.Left > 0)
                return TaskBarLocation.LEFT;
            if (SystemParameters.WorkArea.Top > 0)
                return TaskBarLocation.TOP;
            if (SystemParameters.WorkArea.Left == 0
              && SystemParameters.WorkArea.Width < SystemParameters.PrimaryScreenWidth)
                return TaskBarLocation.RIGHT;
            return TaskBarLocation.BOTTOM;
        }


    }
}
