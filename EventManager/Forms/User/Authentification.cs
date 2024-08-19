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
            if (UserList.users.Count > 0)
            {
                listBox_ProfileList.Items.Clear();

                foreach (User user in UserList.users)
                {
                    listBox_ProfileList.Items.Add($"{user.FirstName} {user.LastName}");
                }

                listBox_ProfileList.Update();
            }
        }

        private void button_UserCreate_Click(object sender, EventArgs e)
        {
            userEditor.ButtonName = "Create User";
            userEditor.ShowDialog();
        }

        private void button_UserEdit_Click(object sender, EventArgs e)
        {
            userEditor.ButtonName = "Edit User";
            userEditor.CurrentInd = listBox_ProfileList.SelectedIndex;

            userEditor.ShowDialog();
        }

        private void Form_Authentification_Activated(object sender, EventArgs e)
        {
            button_UserDelete.Enabled = false;
            button_UserEdit.Enabled = false;
            button_UserConnect.Enabled = false;

            userEditor.FormClosed += UserEditor_FormClosed;
        }

        private void UserEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (UserList.users.Count > 0)
            {
                UpdateList();
                listBox_ProfileList.Enabled = true;
            }
            else
            {
                listBox_ProfileList.Enabled = false;
            }
        }

        private void listBox_ProfileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_ProfileList.SelectedIndex != -1)
            {
                button_UserEdit.Enabled = true;
                button_UserDelete.Enabled = true;
                button_UserConnect.Enabled = true;
            }
            else
            {
                button_UserEdit.Enabled = false;
                button_UserDelete.Enabled = false;
                button_UserConnect.Enabled = false;
            }
        }
    }
}
