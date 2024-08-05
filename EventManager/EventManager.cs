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

            if (eventEditor.eventName != null && eventEditor.eventAuthor != null)
            {
                Event newEvent = new Event(eventEditor.eventName, eventEditor.eventAuthor, eventEditor.eventStart, eventEditor.eventEnd, eventEditor.eventDes);

                eventEditor.Dispose();

                events.Add(newEvent);

                if (events.Count > 0)
                {
                    Console.WriteLine($"List updated, new size of List : {events.Count}");

                    Console.WriteLine($"Author name : {events[0].eventAuthor}");

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
        }

        private void button_EditEvent_Click(object sender, EventArgs e)
        {
            Event eventItem = events[listBox_Events.SelectedIndex];

            Console.WriteLine(eventItem.DisplayEvent());

            Form_EventEditor eventEditor = new Form_EventEditor();

            eventEditor.eventName = eventItem.eventName;
            eventEditor.eventAuthor = eventItem.eventAuthor;
            eventEditor.eventStart = eventItem.eventStart;
            eventEditor.eventEnd = eventItem.eventEnd;
            eventEditor.eventDes = eventItem.eventDes;

            eventEditor.Show(this);
        }

        private void listBox_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Events.SelectedIndex >= 0 && events[listBox_Events.SelectedIndex].ToString().Length > 0)
            {
                button_EditEvent.Enabled = true;
                button_DeleteEvent.Enabled = true;
            }
            else
            {
                button_EditEvent.Enabled = false;
                button_DeleteEvent.Enabled = false;
            }
        }
    }
}
