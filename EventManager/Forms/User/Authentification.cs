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
    /// <summary>
    /// Instance of the Windows Form “Authentification”.
    /// </summary>
    public partial class Form_Authentification : Form
    {
        public Form_Authentification()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            // Update the list after retrieving all users in UserList.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_UserEditor userEdit = new Form_UserEditor();

            userEdit.ShowDialog();
        }
    }
}
