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
        public static List<Event> Events { get; set; } = new List<Event>();
    }
}
