using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class Event
    {
        #region variables

        private string _eventName;
        private string _eventAuthor;
        private DateTime _eventStart;
        private DateTime _eventEnd;
        private string _eventDes;

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

        #endregion

        public Event()
        {
            _eventName = "";
            _eventAuthor = "";
            _eventStart = DateTime.Now;
            _eventEnd = DateTime.Now;
            _eventDes = "";
        }
        public Event(string eventName, string eventAuthor, DateTime eventStart, DateTime eventEnd, string eventDes = "")
        {
            _eventName = eventName;
            _eventAuthor = eventAuthor;
            _eventStart = eventStart;
            _eventEnd = eventEnd;
            _eventDes = eventDes;
        }

        public string DisplayEvent()
        {
            if (eventDes.Length > 0)
            {
                return eventName + ", created by : " + eventAuthor + ". Event starting at : " + eventStart + " and finishing at : " + eventEnd + ". The description is empty.";
            }
            else
            {
                return eventName + ", created by : " + eventAuthor + ". Event starting at : " + eventStart + " and finishing at : " + eventEnd + " with the description '" + eventDes + "'.";
            }
        }
    }
}
