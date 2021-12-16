using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_World___AFK_Away.Classes
{
    class Interval
    {
        public int convertTimeInterval(decimal hours, decimal minutes, decimal seconds)
        {
            int hoursToSecconds;
            int minutesToSeconds;
            int totalTimeInMilliseconds;

            hoursToSecconds = ((int)hours * 3600);
            minutesToSeconds = ((int)minutes * 60);

            totalTimeInMilliseconds = ((hoursToSecconds + minutesToSeconds + (int)seconds) * 1000);

            return totalTimeInMilliseconds;
        }

        public int getRandomInterval()
        {
            Random r = new Random();
            int rInt = r.Next(1000, 60000);
            Console.WriteLine(rInt);

            return rInt;
        }
    }
}
