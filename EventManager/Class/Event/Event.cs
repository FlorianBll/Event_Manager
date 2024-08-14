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
        
        
        #region variables

        private string _eventName;
        private string _eventAuthor;
        private DateTime _eventStart;
        private DateTime _eventEnd;
        private string _eventDes;
        private EventReminder.remindSet _reminderOpt;
        private System.Timers.Timer _timer;

        #endregion

        #region get/set

        public string eventName
        {
            get => _eventName;
            set => _eventName = value;
        }

        public string eventAuthor
        {
            get => _eventAuthor;
            set => _eventAuthor = value;
        }

        public DateTime eventStart
        {
            get => _eventStart;
            set => _eventStart = value;
        }

        public DateTime eventEnd
        {
            get => _eventEnd;
            set => _eventEnd = value;
        }

        public string eventDes
        {
            get => _eventDes;
            set => _eventDes = value;
        }

        public EventReminder.remindSet reminderOpt
        {
            get => _reminderOpt;
            set => _reminderOpt = value;
        }

        public System.Timers.Timer timer
        {
            get => _timer;
            set => _timer = value;
        }

        #endregion

        #region constructor
        public Event()
        {
            _eventName = "";
            _eventAuthor = "";
            _eventStart = DateTime.Now;
            _eventEnd = DateTime.Now;
            _eventDes = "";
            _reminderOpt = 0;
        }
        public Event(string eventName, string eventAuthor, DateTime eventStart, DateTime eventEnd, string eventDes = "", EventReminder.remindSet reminderOpt = 0)
        {
            _eventName = eventName;
            _eventAuthor = eventAuthor;
            _eventStart = eventStart;
            _eventEnd = eventEnd;
            _eventDes = eventDes;
            _reminderOpt = reminderOpt;
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
            if (eventDes.Length > 0)
            {
                Console.WriteLine($"{eventName}, created by : {eventAuthor}. Event starting at : {eventStart} and finishing at : {eventEnd} with the description {eventDes}.");
            }
            else
            {
                Console.WriteLine($"{eventName}, created by : {eventAuthor}. Event starting at : {eventStart} and finishing at : {eventEnd}. The description is empty.");
            }
        }
    }
}
