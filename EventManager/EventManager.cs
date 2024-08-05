using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Form_EventManager : Form
    {
        // List of events
        List<Event> events = new List<Event>();
        Form_EventEditor editor = new Form_EventEditor();


        public Form_EventManager()
        {
            InitializeComponent();
        }

        private void button_CreateEvent_Click(object sender, EventArgs e)
        {
            editor.buttonName = "Create Event";
            editor.ShowDialog(this);
        }

        private void button_EditEvent_Click(object sender, EventArgs e)
        {
            editor.buttonName = "Edit Event";
            editor.ShowDialog(this);
        }

        private void listBox_Events_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Events.SelectedIndex >= 0 && events[listBox_Events.SelectedIndex].eventName.Length > 0)
            {
                button_EditEvent.Enabled = true;
                button_DeleteEvent.Enabled = true;

                Console.WriteLine($"Event Description : {events[listBox_Events.SelectedIndex].eventDes}");
            }
            else
            {
                button_EditEvent.Enabled = false;
                button_DeleteEvent.Enabled = false;
            }
        }

        private void Form_EventManager_Activated(object sender, EventArgs e)
        {
            Event newEvent = editor.eventItem;

            if (newEvent != null)
            {
                if (events.Count <= 0 && newEvent.eventName.Length > 0)
                {
                    events.Add(newEvent);

                    if (listBox_Events.Items.Count <= 0)
                    {
                        listBox_Events.Items.Add(newEvent.eventName);
                        listBox_Events.Update();
                    }
                    else
                    {
                        listBox_Events.Items.Clear();
                        listBox_Events.Items.Add(newEvent.eventName);
                        listBox_Events.Update();
                    }
                }
                else
                {
                    events[listBox_Events.SelectedIndex] = newEvent;
                }
            }
        }
    }
}
