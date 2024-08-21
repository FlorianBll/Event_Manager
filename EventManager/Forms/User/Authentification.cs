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
        #region variables/instances

        private Form_UserEditor userEditor = new Form_UserEditor();
        public Form_Login login = new Form_Login();

        private int CurrentInd;

        #endregion

        public Form_Authentification()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Refresh the listbox for showing Users
        /// </summary>
        public void UpdateUserList()
        {
            if (UserList.Users.Count > 0)
            {
                listBox_ProfileList.Items.Clear();

                foreach (User user in UserList.Users)
                {
                    listBox_ProfileList.Items.Add($"{user.FirstName} {user.LastName}");
                }

                listBox_ProfileList.Update();
            }
            else
            {
                listBox_ProfileList.Items.Clear();
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

        private void button_UserDelete_Click(object sender, EventArgs e)
        {
            if (listBox_ProfileList.SelectedIndex != -1)
            {
                User user = UserList.Users[listBox_ProfileList.SelectedIndex];

                if (MessageBox.Show($"Are you sure to delete '{user.FirstName} {user.LastName}' profile ?", "User deleted", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    UserList.Users.Remove(user);

                    button_UserConnect.Enabled = false;
                    button_UserEdit.Enabled = false;
                    button_UserDelete.Enabled = false;

                    UpdateUserList();
                }
            }
        }

        private void Form_Authentification_Activated(object sender, EventArgs e)
        {
            UpdateUserList();

            if (listBox_ProfileList.Items.Count <= 0)
            {
                CurrentInd = listBox_ProfileList.SelectedIndex;

                button_UserEdit.Enabled = false;
                button_UserDelete.Enabled = false;
                button_UserConnect.Enabled = false;

                listBox_ProfileList.Enabled = false;
            }
            else
            {
                button_UserEdit.Enabled = true;
                button_UserDelete.Enabled = true;
                button_UserConnect.Enabled = true;

                CurrentInd = UserList.Users.IndexOf(UserList.Users.Last());

                listBox_ProfileList.Enabled = true;
                listBox_ProfileList.SetSelected(CurrentInd, true);
            }

            login.button_Login.Click += Button_Login_Click;
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox_ProfileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentInd != -1)
            {
                button_UserEdit.Enabled = true;
                button_UserDelete.Enabled = true;
                button_UserConnect.Enabled = true;

                CurrentInd = listBox_ProfileList.SelectedIndex;
            }
        }

        private void button_UserConnect_Click(object sender, EventArgs e)
        {
            User user = UserList.Users[CurrentInd];

            login.UserName = $"{user.FirstName} {user.LastName}";
            login.UserIndex = CurrentInd;

            login.ShowDialog();
        }
    }
}
