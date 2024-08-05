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
        #region variables

        private string _eventName;
        private string _eventAuthor;
        private DateTime _eventStart;
        private DateTime _eventEnd;
        private string _eventDes;

        public string eventName
        {
            get => _eventName;
            set => _eventName = value;
        }

        public string eventAuthor
        {
            get => _eventAuthor;
            set => _eventAuthor = value;
        }

        public DateTime eventStart
        {
            get => _eventStart;
            set => _eventStart = value;
        }

        public DateTime eventEnd
        {
            get => _eventEnd;
            set => _eventEnd = value;
        }

        public string eventDes
        {
            get => _eventDes;
            set => _eventDes = value;
        }

        #endregion

        public Form_EventEditor()
        {
            InitializeComponent();
        }


        private void Form_EventEditor_Load(object sender, EventArgs e)
        {
            // Check if an selected event will be edited
            bool isEventEdited = eventName != null && eventAuthor != null;

            if (isEventEdited)
            {
                button_CreateEvent.Text = "Edit Event";

                textBox_EventName.Text = eventName;
                textBox_Author.Text = eventAuthor;
                dateTimePicker_StartEvent.Value = eventStart;
                dateTimePicker_EndEvent.Value = eventEnd;
                richTextBox_EventDescription.Text = eventDes;
            }
        }

        private void textBox_EventName_TextChanged(object sender, EventArgs e)
        {
            eventName = textBox_EventName.Text;
            eventAuthor = textBox_Author.Text;

            if (eventName.Length > 0 && eventAuthor.Length > 0)
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
            eventName = textBox_EventName.Text;
            eventAuthor = textBox_Author.Text;

            if (eventName.Length > 0 && eventAuthor.Length > 0)
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
                eventName = textBox_EventName.Text;
                eventAuthor = textBox_Author.Text;

                if (richTextBox_EventDescription.TextLength > 0)
                {
                    eventDes = richTextBox_EventDescription.Text;
                }
                else
                {
                    eventDes = "";
                }

                DateTime start = dateTimePicker_StartEvent.Value;
                DateTime end = dateTimePicker_EndEvent.Value;

                TimeSpan interval = end - start;

                bool isEventValid = !(interval.Days < 0);

                if (isEventValid)
                {
                    eventStart = dateTimePicker_StartEvent.Value;
                    eventEnd = dateTimePicker_EndEvent.Value;

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
