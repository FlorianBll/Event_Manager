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
        public Form_EventManager()
        {
            InitializeComponent();
        }

        private void button_CreateEvent_Click(object sender, EventArgs e)
        {
            Form_EventEditor evntEdit = new Form_EventEditor();

            evntEdit.ShowDialog();
        }
    }
}
