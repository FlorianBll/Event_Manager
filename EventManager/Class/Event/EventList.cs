using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace EventManager
{
    public static class EventList
    {
        private static List<Event> _events = new List<Event>();
        public static List<Event> events
        {
            get => _events;
            set => _events = value;
        }
    }
}
