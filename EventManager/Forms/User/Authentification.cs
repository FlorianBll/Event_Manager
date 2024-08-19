using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml.Controls;

namespace EventManager
{
    /// <summary>
    /// Instance of the Windows Form “Authentification”.
    /// </summary>
    public partial class Form_Authentification : Form
    {
        private Form_UserEditor userEditor = new Form_UserEditor();
        public Form_Authentification()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            Console.WriteLine($"Number of users = {UserList.users.Count}");

            if (UserList.users.Count > 0)
            {
                foreach (User user in UserList.users)
                {
                    listBox_ProfileList.Items.Add(user.FirstName);
                }

                listBox_ProfileList.Update();
            }
        }

        private void Form_Authentification_Load(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void button_UserCreate_Click(object sender, EventArgs e)
        {
            userEditor.ButtonName = "Create Event";
            userEditor.ShowDialog();
        }

        private void button_UserEdit_Click(object sender, EventArgs e)
        {
            userEditor.ButtonName = "Edit Event";
            userEditor.CurrentInd = listBox_ProfileList.SelectedIndex;

            userEditor.ShowDialog();
        }
    }
}
