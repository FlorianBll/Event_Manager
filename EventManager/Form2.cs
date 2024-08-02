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
        private DateTime _eventDate;
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

        public DateTime eventDate
        {
            get => _eventDate;
            set => _eventDate = value;
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

            eventName = textBox_EventName.Text;
            eventAuthor = textBox_Author.Text;
            eventDate = dateTimePicker_Event.Value;
            eventDes = richTextBox_EventDescription.Text;


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
            bool isFieldsNotEmpty = textBox_EventName.TextLength > 0 && textBox_Author.TextLength > 0 && dateTimePicker_Event.Value != null;

            if (isFieldsNotEmpty)
            {
                eventName = textBox_EventName.Text;
                eventAuthor = textBox_Author.Text;
                eventDate = dateTimePicker_Event.Value;

                if (richTextBox_EventDescription.TextLength > 0)
                {
                    eventDes = richTextBox_EventDescription.Text;
                }
                else
                {
                    eventDes = "";
                }

                Close();
            }
        }
    }
}
