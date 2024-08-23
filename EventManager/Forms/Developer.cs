
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp;
using Microsoft.Toolkit.Uwp.Notifications;

namespace EventManager
{
    /// <summary>
    /// Representing a form with developer options.
    /// </summary>
    public partial class Form_DeveloperToolbox : Form
    {
        public Form_DeveloperToolbox()
        {
            InitializeComponent();
        }

        private void button_NotifPush_Click(object sender, EventArgs e)
        {
            ToastContentBuilder toast = new ToastContentBuilder();

            toast.AddHeader("notifContent", "Event Notification Example", "");
            toast.AddText("This is an event notification example !");

            toast.Show();
        }

        private void button_GetTimers_Click(object sender, EventArgs e)
        {
            List<Event> Events = EventList.Events;

            if (Events.Count > 0)
            {
                foreach (Event eventItm in Events)
                {
                    if (eventItm.Timer.Enabled)
                    {
                        Console.WriteLine($"Event's '{eventItm.EventName} Timer currently running !");
                    }
                }
            }
            else
            {
                Console.WriteLine("No Timers is currently running");
            }
        }

        private void button_XMLConsolePrint_Click(object sender, EventArgs e)
        {
            Console.WriteLine(XML_Manager.Root);
        }
    }
}
