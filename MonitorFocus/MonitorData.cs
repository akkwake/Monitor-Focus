using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorFocus
{
    public static class MonitorData
    {
        /// <summary>
        /// Returns the index of the monitor the cursor is currently in.
        /// Returns -1 if screen count == 1.
        /// Returns -2 if cursor is outside screen bounds.
        /// </summary>
        public static int GetCursorMonitorIndex()
        {
            Screen[] screens = Screen.AllScreens;

            if (screens.Length == 1)
                return -1;
            Point cursorCoords = Cursor.Position;


            for (int i = 0; i < screens.Length; i++)
            {
                Rectangle rect = screens[i].Bounds;
                if (rect.Contains(cursorCoords))
                    return i;
            }

           
            return -2;
        }

    }
}
