using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp;
using Microsoft.Toolkit.Uwp.Notifications;

namespace EventManager
{
    /// <summary>
    /// Static class enabling to display event notification.
    /// </summary>
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
            DateTime now = DateTime.Now;

            TimeSpan interval = e.eventStart - now;

            bool isNow = e.eventStart == now;

            ToastContentBuilder toast = new ToastContentBuilder();

            toast.AddHeader("eventName", e.eventName, "");

            switch ((int)rs)
            {
                case 0:
                    if (isNow && interval.Minutes <= 5)
                    {
                        toast.AddText($"{e.eventName} event will start in 5 min !");
                    }
                break;
                case 1:
                    if (isNow && interval.Minutes <= 10)
                    {
                        toast.AddText($"{e.eventName} event will start in 10 min !");
                    }
                break;
                case 2:
                    if (isNow && interval.Minutes <= 30)
                    {
                        toast.AddText($"{e.eventName} event will start in 30 min !");
                    }
                break;
                case 3:
                    if (isNow && interval.Hours <= 1)
                    {
                        toast.AddText($"{e.eventName} event will start in 1 hour !");
                    }
                break;
                case 4:
                    if (isNow && interval.Hours < 2)
                    {
                        toast.AddText($"{e.eventName} event will start in 2 hours !");
                    }
                break;
                case 5:
                    if (interval.Days <= 1)
                    {
                        toast.AddText($"{e.eventName} event will start tomorrow !");
                    }
                break;
            }

            toast.Show();
        }
    }
}
