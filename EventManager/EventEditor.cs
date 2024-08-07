using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Form_EventEditor : Form
    {
        private Event _eventItem;
        private string _buttonName;

        public Event eventItem
        {
            get => _eventItem;
            set => _eventItem = value;
        }

        public string buttonName
        {
            get => _buttonName;
            set => _buttonName = value;
        }
        public Form_EventEditor()
        {
            InitializeComponent();
        }


        private void Form_EventEditor_Load(object sender, EventArgs e)
        {
            button_CreateEvent.Text = buttonName;

            dateTimePicker_StartEvent.Format = DateTimePickerFormat.Custom;
            dateTimePicker_StartEvent.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            dateTimePicker_EndEvent.Format = DateTimePickerFormat.Custom;
            dateTimePicker_EndEvent.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            if (eventItem != null && buttonName == "Edit Event")
            {
                Event currentEvent = eventItem;

                textBox_EventName.Text = currentEvent.eventName;
                textBox_Author.Text = currentEvent.eventAuthor;
                dateTimePicker_StartEvent.Value = currentEvent.eventStart;
                dateTimePicker_EndEvent.Value = currentEvent.eventEnd;
                richTextBox_EventDescription.Text = currentEvent.eventDes;
                comboBox_Reminder.SelectedIndex = (int)currentEvent.reminderOpt;
            }
            else
            {
                textBox_EventName.Clear();
                textBox_Author.Clear();
                dateTimePicker_StartEvent.Value = DateTime.Now;
                dateTimePicker_EndEvent.Value = DateTime.Now;
                richTextBox_EventDescription.Text = "";
                comboBox_Reminder.SelectedIndex = 0;
            }
        }

        private void textBox_EventName_TextChanged(object sender, EventArgs e)
        {
            if (textBox_EventName.TextLength > 0 && textBox_Author.TextLength > 0)
            {
                button_CreateEvent.Enabled = true;
            }
            else
            {
                button_CreateEvent.Enabled = false; 
            }
        }

        private void textBox_Author_TextChanged(object sender, EventArgs e)
        {
            if (textBox_EventName.TextLength > 0 && textBox_Author.TextLength > 0)
            {
                button_CreateEvent.Enabled = true;
            }
            else
            {
                button_CreateEvent.Enabled = false;
            }
        }

        private void button_CreateEvent_Click(object sender, EventArgs e)
        {
            bool isFieldsNotEmpty = textBox_EventName.TextLength > 0 && textBox_Author.TextLength > 0 && dateTimePicker_StartEvent.Value != null && dateTimePicker_EndEvent.Value != null;

            if (isFieldsNotEmpty)
            {
                Event newEvent = new Event();

                DateTime start = dateTimePicker_StartEvent.Value;
                DateTime end = dateTimePicker_EndEvent.Value;

                TimeSpan interval = end - start;

                bool isEventValid = !(interval.Hours < 0);

                if (isEventValid)
                {
                    newEvent.eventName = textBox_EventName.Text;
                    newEvent.eventAuthor = textBox_Author.Text;

                    if (richTextBox_EventDescription.TextLength > 0)
                    {
                        newEvent.eventDes = richTextBox_EventDescription.Text;
                    }
                    else
                    {
                        newEvent.eventDes = "";
                    }
                    newEvent.eventStart = dateTimePicker_StartEvent.Value;
                    newEvent.eventEnd = dateTimePicker_EndEvent.Value;

                    newEvent.reminderOpt = (EventReminder.remindSet)comboBox_Reminder.SelectedIndex;

                    eventItem = newEvent;

                    EventReminder.Remind(eventItem, eventItem.reminderOpt);

                    ToastContentBuilder toast = new ToastContentBuilder();

                    toast.AddHeader("eventCreation", "Event created", "");
                    toast.AddText($"Event created with the name '{eventItem.eventName}'");

                    toast.Show();

                    Close();
                }
                else
                {
                    MessageBox.Show("The ending date can't be an ulterior date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
