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
        #region variable

        private Form_EventEditor _editor = new Form_EventEditor();
        private bool _isDevModeEnabled = true;

        #endregion

        #region get/set
        public Form_EventEditor editor
        {
            get => _editor;
            set => _editor = value;
        }

        public bool isDevModeEnabled
        {
            get => _isDevModeEnabled;
            set => _isDevModeEnabled = value;
        }

        #endregion
        public Form_EventManager()
        {
            InitializeComponent();

            if (isDevModeEnabled)
            {
                button_DevMode.Visible = true;
            }
            else
            {
                button_DevMode.Visible = false;
            }
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
            if (listBox_Events.SelectedIndex >= 0 && EventList.events[listBox_Events.SelectedIndex].eventName.Length > 0)
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

        private void Form_EventManager_Activated(object sender, EventArgs e)
        {
            Event newEvent = editor.eventItem;

            if (newEvent != null)
            {
                if (newEvent.eventName.Length > 0)
                {
                    EventList.events.Add(newEvent);

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
                else if (listBox_Events.SelectedIndex >= 0)
                {
                    EventList.events[listBox_Events.SelectedIndex] = newEvent;
                }
            }
        }

        private void textBox_SearchEventName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_SearchEventName.TextLength > 0)
            {
                button_SearchEvent.Enabled = true;
            }
            else
            {
                button_SearchEvent.Enabled = false;
            }
        }

        private void button_SearchEvent_Click(object sender, EventArgs e)
        {
            if (listBox_Events.Items.IndexOf(textBox_SearchEventName.Text) >= 0)
            {
                listBox_Events.SelectedItem = listBox_Events.Items.IndexOf(textBox_SearchEventName.Text);
            }
        }

        private void button_DeleteEvent_Click(object sender, EventArgs e)
        {
            int index = listBox_Events.SelectedIndex;

            if (listBox_Events.SelectedIndex >= 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this selected event ? This action is irreversible", "Deleting Event", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    Console.WriteLine(index);

                    Event currentEvent = EventList.events[index];

                    EventReminder.Remove(currentEvent);

                    EventList.events.RemoveAt(index);
                    listBox_Events.Items.RemoveAt(index);                    
                    listBox_Events.Update();
                }
            }
        }

        private void button_DevMode_Click(object sender, EventArgs e)
        {
            Form_DeveloperToolbox devMode = new Form_DeveloperToolbox();

            devMode.ShowDialog();
        }
    }
}
