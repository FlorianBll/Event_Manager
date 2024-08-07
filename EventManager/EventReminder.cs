using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Microsoft.Toolkit.Uwp;
using Microsoft.Toolkit.Uwp.Notifications;

namespace EventManager
{
    /// <summary>
    /// Static class enabling to display event notification.
    /// </summary>
    public static class EventReminder
    {
        #region variables
        private static Event _event;
        private static System.Timers.Timer _timer;

        public enum remindSet
        {
            FIVEMIN = 0,
            TENMIN = 1,
            HALFHOUR = 2,
            ONEHOUR = 3,
            TWOHOUR = 4,
            ONEDAY = 5,
        }

        #endregion

        /// <summary>
        /// Enable to attach a remind to an event instance.
        /// </summary>
        /// <param name="e">The event instance</param>
        /// <param name="rs">The remindSet option to choose. (By default, this option is set to 0).</param>
        
        public static void Remind(Event e, remindSet rs = 0)
        {
            DateTime now = DateTime.Now;

            TimeSpan interval = e.eventStart - now;

            _timer = new System.Timers.Timer();

            switch ((int)rs)
            {
                case 0:
                    _timer.Interval = interval.Milliseconds - (5 * 60 * 1000);
                break;
                case 1:
                    _timer.Interval = interval.Milliseconds - (10 * 60 * 1000);
                break;
                case 2:
                    _timer.Interval = interval.Milliseconds - (30 * 60 * 1000);
                break;
                case 3:
                    _timer.Interval = interval.Milliseconds - (60 * 60 * 1000);
                break;
                case 4:
                    _timer.Interval = interval.Milliseconds - (2 * 60 * 60 * 1000);
                break;
                case 5:
                    _timer.Interval = interval.Milliseconds - (24 * 60 * 60 *  1000);
                break;
            }

            // Handling the event instance for reusing it in the 'Timer_Elasped' event
            _event = e;

            _timer.Start();

            _timer.Elapsed += Timer_Elapsed;
        }

        private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ToastContentBuilder toast = new ToastContentBuilder();

            toast.AddHeader("eventName", _event.eventName, "");
            toast.AddText(_event.eventDes);

            toast.Show();

            _timer.Stop();
        }
    }
}
