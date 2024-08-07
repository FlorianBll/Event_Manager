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
                    _timer.Interval = (5 * 60 * 1000) - interval.Milliseconds;
                break;
                case 1:
                    _timer.Interval = (10 * 60 * 1000) - interval.Milliseconds;
                break;
                case 2:
                    _timer.Interval = (30 * 60 * 1000) - interval.Milliseconds;
                break;
                case 3:
                    _timer.Interval = (60 * 60 * 1000) - interval.Milliseconds;
                break;
                case 4:
                    _timer.Interval = (2 * 60 * 60 * 1000) - interval.Milliseconds;
                break;
                case 5:
                    _timer.Interval = (24 * 60 * 60 * 1000) - interval.Milliseconds;
                break;
            }
            
            // Handling the event instance for reusing it in the 'Timer_Elapsed' event
            _event = e;

            // Attach the timer to the event
            _event.isTimerAttached = true;

            _timer.Start();

            Console.WriteLine($"Timer set with {_timer.Interval}ms");

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
        /// <summary>
        /// Removing the current timer
        /// </summary>
        /// <param name="e">the event from which the timer is removed</param>
        public static void Remove(Event e)
        {
            if (e.isTimerAttached)
            {
                e.isTimerAttached = false;

                Console.WriteLine("The current timer has been removed !");

                _timer.Stop();
                _timer.Dispose();
            }
        }
    }
}
