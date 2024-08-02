using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Form_EventManager : Form
    {
        // Empty Event instance
        Event newEvent = new Event();

        // List of events
        List<Event> events = new List<Event>();


        public Form_EventManager()
        {
            InitializeComponent();
        }

        private void button_CreateEvent_Click(object sender, EventArgs e)
        {
            Form_EventEditor eventEditor = new Form_EventEditor();

            eventEditor.ShowDialog(this);

            // Retrieve all data from Event Editor form
            newEvent.eventName = eventEditor.eventName;
            newEvent.eventAuthor = eventEditor.eventAuthor;
            newEvent.eventDate = eventEditor.eventDate;
            newEvent.eventDes = eventEditor.eventDes;

            eventEditor.Dispose();

            events.Add(newEvent);

            if (events.Count > 0)
            {
                Console.WriteLine($"List updated, new size of List : {events.Count}");
            }
        }
    }
}
