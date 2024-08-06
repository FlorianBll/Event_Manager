using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp;

namespace EventManager
{
    public static class EventReminder
    {
        public enum remindSet
        {
            FIVEMIN = 0,
            TENMIN = 1,
            HALFHOUR = 2,
            ONEHOUR = 3,
            TWOHOUR = 4,
            ONEDAY = 5,
        }

        public static void Remind(Event e, remindSet rs)
        {
            TimeSpan interval = e.eventEnd - e.eventStart;

            switch (rs)
            {
                // Sshow a Toast depending on the calculation between the event start and the current date
            }
        }
    }
}
