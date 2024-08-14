
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
            List<Event> events = EventList.events;

            if (events.Count > 0)
            {
                foreach (Event eventItm in events)
                {
                    if (eventItm.timer.Enabled)
                    {
                        Console.WriteLine($"Event's '{eventItm.eventName} timer currently running !");
                    }
                }
            }
            else
            {
                Console.WriteLine("No timers is currently running");
            }
        }
    }
}
