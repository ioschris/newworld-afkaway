using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_World___AFK_Away.Classes
{
    class ClickType
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        uint X = (uint)Cursor.Position.X;
        uint Y = (uint)Cursor.Position.Y;

        public void singleLeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void doubleLeftClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        public void wasd()
        {
            SendKeys.Send(Keys.W.ToString());
            SendKeys.Send(Keys.A.ToString());
            SendKeys.Send(Keys.S.ToString());
            SendKeys.Send(Keys.D.ToString());
        }

        public void wasdSingle()
        {
            wasd();
            singleLeftClick();
        }

        public void wasdDouble()
        {
            wasd();
            doubleLeftClick();
        }

        public void selectedType(int i)
        {
            switch (i)
            {
                case 0:
                    singleLeftClick();
                    break;
                case 1:
                    doubleLeftClick();
                    break;
                case 2:
                    wasd();
                    break;
                case 3:
                    wasdSingle();
                    break;
                case 4:
                    wasdDouble();
                    break;
            }
        }
    }
}
