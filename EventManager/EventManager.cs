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

            Event newEvent = new Event(eventEditor.eventName, eventEditor.eventAuthor, eventEditor.eventStart, eventEditor.eventEnd, eventEditor.eventDes);

            eventEditor.Dispose();

            events.Add(newEvent);

            if (events.Count > 0)
            {
                Console.WriteLine($"List updated, new size of List : {events.Count}");

                if (listBox_Events.Items.Count <= 0)
                {
                    listBox_Events.Items.Add(events[0].eventName);

                    listBox_Events.Update();
                }
                else
                {
                    listBox_Events.Items.Clear();

                    foreach (Event eventItem in events)
                    {
                        listBox_Events.Items.Add(eventItem.eventName);
                    }

                    listBox_Events.Update();
                }
            }
        }

        private void listBox_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("User clicked on event");
        }
    }
}
