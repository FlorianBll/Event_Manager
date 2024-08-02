using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    public class Event
    {
        #region variables

        private string _eventName;
        private string _eventAuthor;
        private DateTime _eventDate;
        private string _eventDes;

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

        public DateTime eventDate
        {
            get => _eventDate;
            set => _eventDate = value;
        }

        public string eventDes
        {
            get => _eventDes;
            set => _eventDes = value;
        }

        #endregion

        public Event(string eventName, string eventAuthor, DateTime eventDate, string eventDes = "")
        {
            _eventAuthor = eventName;
            _eventAuthor = eventAuthor;
            _eventDate = eventDate;
            _eventDes = eventDes;
        }


    }
}
