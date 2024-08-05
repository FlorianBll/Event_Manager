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

            if (eventItem != null && buttonName == "Edit Event")
            {
                Event currentEvent = eventItem;

                textBox_EventName.Text = eventItem.eventName;
                textBox_Author.Text = eventItem.eventAuthor;
                dateTimePicker_StartEvent.Value = eventItem.eventStart;
                dateTimePicker_EndEvent.Value = eventItem.eventEnd;
                richTextBox_EventDescription.Text = eventItem.eventDes;
            }
            else
            {
                textBox_EventName.Clear();
                textBox_Author.Clear();
                dateTimePicker_StartEvent.Value = DateTime.Now;
                dateTimePicker_EndEvent.Value = DateTime.Now;
                richTextBox_EventDescription.Clear();
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

                DateTime start = dateTimePicker_StartEvent.Value;
                DateTime end = dateTimePicker_EndEvent.Value;

                TimeSpan interval = end - start;

                bool isEventValid = !(interval.Days < 0);

                if (isEventValid)
                {
                    newEvent.eventStart = dateTimePicker_StartEvent.Value;
                    newEvent.eventEnd = dateTimePicker_EndEvent.Value;

                    eventItem = newEvent;

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
