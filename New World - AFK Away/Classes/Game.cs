using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_World___AFK_Away.Classes
{
    class Game
    {
        public string checkGameState()
        {
            Process[] newWorld = Process.GetProcessesByName("NewWorld");
            string returnResult;

            if (newWorld.Length == 0)
                returnResult = "Not Running";
            else
                returnResult = "Running";

            return returnResult;
        }
    }
}
