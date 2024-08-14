using EventManager.Forms.User;
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
    public partial class Form_Authentification : Form
    {
        public Form_Authentification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_CreateEdit_User userEdit = new Form_CreateEdit_User();

            userEdit.ShowDialog();
        }
    }
}
