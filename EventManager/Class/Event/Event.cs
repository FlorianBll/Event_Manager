using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    /// <summary>
    /// Class representing an Event instance. 
    /// </summary>
    /// <remarks>
    /// This instance of Event containing a Name, an Author, a Date, Description and a reminder option.
    /// The description and/or the reminder option of the event can be empty if unused.
    /// </remarks>
    public class Event
    {
        #region get/set

        public string EventName { get; set; }
        public string EventAuthor { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }

        public string EventDes { get; set; }

        public EventReminder.RemindSet ReminderOpt { get; set; } = 0;

        public System.Timers.Timer Timer { get; set; }

        #endregion

        #region constructor
        public Event()
        {
            EventName = string.Empty;
            EventAuthor = string.Empty;
            EventStart = DateTime.Now;
            EventEnd = DateTime.Now;
            EventDes = string.Empty;
            ReminderOpt = 0;
        }
        public Event(string eventName, string eventAuthor, DateTime eventStart, DateTime eventEnd, string eventDes = "", EventReminder.RemindSet reminderOpt = 0)
        {
            EventName = eventName;
            EventAuthor = eventAuthor;
            EventStart = eventStart;
            EventEnd = eventEnd;
            EventDes = eventDes;
            ReminderOpt = reminderOpt;
        }
        #endregion

        /// <summary>
        /// Show the event details in the console. Can be used as a test if an Event instance is not empty.
        /// </summary>
        /// <returns>
        /// Message with the event details like the event name, author, start stae, end date and event description.
        /// </returns>
        public void DisplayEvent()
        {
            if (EventDes.Length > 0)
            {
                Console.WriteLine($"{EventName}, created by : {EventAuthor}. Event starting at : {EventStart} and finishing at : {EventEnd} with the description {EventDes}.");
            }
            else
            {
                Console.WriteLine($"{EventName}, created by : {EventAuthor}. Event starting at : {EventStart} and finishing at : {EventEnd}. The description is empty.");
            }
        }
    }
}
