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
        #region get/set

        public int currentInd { get; set; }
        public string buttonName { get; set; }

        public string UserName { get; set; }

        #endregion

        /// <summary>
        /// Create an event and store it into a list of Eventss using EventList class.
        /// </summary>
        public void CreateEvent()
        {
            bool isEventExist = false;

            if (EventList.Events != null && EventList.Events.Count >= 0)
            {
                foreach (Event eventItem in EventList.Events)
                {
                    if (eventItem.EventName == textBox_EventName.Text)
                    {
                        Console.WriteLine("The event already exist");
                        isEventExist = true;
                    }
                    else
                    {
                        isEventExist = false;
                    }
                }
            }

            if (!isEventExist)
            {
                Event newEvent = new Event();

                DateTime start = dateTimePicker_StartEvent.Value;
                DateTime end = dateTimePicker_EndEvent.Value;

                TimeSpan interval = end - start;

                Console.WriteLine($"Interval in hours = {interval.Hours}; Interval in days = {interval.Days}");

                bool isEventDateValid = interval.Hours > 0 && interval.Days > 0;

                if (isEventDateValid)
                {
                    newEvent.EventName = textBox_EventName.Text.ToLower();
                    newEvent.EventAuthor = textBox_Author.Text.ToLower();

                    if (richTextBox_EventDescription.TextLength > 0)
                    {
                        newEvent.EventDes = richTextBox_EventDescription.Text.ToLower();
                    }

                    newEvent.EventStart = dateTimePicker_StartEvent.Value;
                    newEvent.EventEnd = dateTimePicker_EndEvent.Value;

                    newEvent.ReminderOpt = (EventReminder.RemindSet)comboBox_Reminder.SelectedIndex;

                    EventReminder.Remind(newEvent, newEvent.ReminderOpt);

                    ToastContentBuilder toast = new ToastContentBuilder();

                    toast.AddHeader("eventCreation", "Event created", "");
                    toast.AddText($"Event created with the name '{newEvent.EventName}'");

                    toast.Show();

                    EventList.Events.Add(newEvent);

                    Close();
                }
                else
                {
                    MessageBox.Show("The ending date can't be an ulterior date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("An event already exist containing the same name. Please choose an other name", "Event name already exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Get Event instance correponding to is index.
        /// </summary>
        /// <returns>The event matching to the current index.</returns>
        private Event GetEvent()
        {
            return EventList.Events[currentInd];
        }
        /// <summary>
        /// Edit an existing event present on the EventList.
        /// </summary>
        /// <param name="index"></param>
        public void EditEvent(int index)
        {
            Event e = GetEvent();

            bool isEventAlreadyExist = false;

            foreach (Event eventItm in EventList.Events)
            {
                if (EventList.Events.IndexOf(eventItm) != index && eventItm.EventName == textBox_EventName.Text)
                {
                    isEventAlreadyExist = true;
                }
            }

            if (e != null && !isEventAlreadyExist)
            {
                DateTime end = e.EventEnd;
                DateTime start = e.EventStart;

                TimeSpan interval = end - start;

                Console.WriteLine($"Interval in hours = {interval.Hours}; Interval in days = {interval.Days}");

                bool isEventDateValid = interval.Hours > 0 && interval.Days > 0;

                if (isEventDateValid)
                {
                    e.EventName = textBox_EventName.Text.ToLower();
                    e.EventAuthor = textBox_Author.Text.ToLower();

                    e.EventDes = richTextBox_EventDescription.Text.ToLower();

                    e.EventStart = dateTimePicker_StartEvent.Value;
                    e.EventEnd = dateTimePicker_EndEvent.Value;

                    e.ReminderOpt = (EventReminder.RemindSet)comboBox_Reminder.SelectedIndex;

                    EventReminder.Remind(e, e.ReminderOpt);
                }
                else
                {
                    MessageBox.Show("The ending date can't be an ulterior date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                EventList.Events[index] = e;

                ToastContentBuilder toast = new ToastContentBuilder();

                toast.AddHeader("eventEdition", "Event edited", "");
                toast.AddText($"Event '{e.EventName}' edited");

                toast.Show();

                Close();
            }
            else
            {
                MessageBox.Show("The event is null or already exist", "Event null/Already exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        /// <summary>
        /// Enable Create/Edit button if all fields are not empty.
        /// </summary>
        private void EnableButton()
        {
            bool isAllFieldFilled = textBox_EventName.TextLength > 0 && textBox_Author.TextLength > 0;

            if (isAllFieldFilled)
            {
                button_CreateEditEvent.Enabled = true;
            }
            else
            {
                button_CreateEditEvent.Enabled = false;
            }
        }

        public Form_EventEditor()
        {
            InitializeComponent();
        }


        private void Form_EventEditor_Load(object sender, EventArgs e)
        {
            button_CreateEditEvent.Text = buttonName;

            dateTimePicker_StartEvent.Format = DateTimePickerFormat.Custom;
            dateTimePicker_StartEvent.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            dateTimePicker_EndEvent.Format = DateTimePickerFormat.Custom;
            dateTimePicker_EndEvent.CustomFormat = "MM/dd/yyyy HH:mm:ss";

            if (currentInd >= 0 && buttonName == "Edit Event")
            {
                Event eventItm = EventList.Events[currentInd];

                textBox_EventName.Text = eventItm.EventName;
                textBox_Author.Text = eventItm.EventAuthor;
                dateTimePicker_StartEvent.Value = eventItm.EventStart;
                dateTimePicker_EndEvent.Value = eventItm.EventEnd;
                richTextBox_EventDescription.Text = eventItm.EventDes;
                comboBox_Reminder.SelectedIndex = (int)eventItm.ReminderOpt;
            }
            else
            {
                textBox_EventName.Clear();
                textBox_Author.Text = UserName;
                dateTimePicker_StartEvent.Value = DateTime.Now;
                dateTimePicker_EndEvent.Value = DateTime.Now;
                richTextBox_EventDescription.Text = "";
                comboBox_Reminder.SelectedIndex = 0;
            }
        }

        private void textBox_EventName_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void textBox_Author_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void button_CreateEditEvent_Click(object sender, EventArgs e)
        {
            bool isFieldsNotEmpty = textBox_EventName.TextLength > 0 && textBox_Author.TextLength > 0 && dateTimePicker_StartEvent.Value != null && dateTimePicker_EndEvent.Value != null;

            if (isFieldsNotEmpty)
            {
                if (buttonName == "Create Event")
                {
                    CreateEvent();
                }
                else
                {
                    EditEvent(currentInd);
                }
            }
        }
    }
}
