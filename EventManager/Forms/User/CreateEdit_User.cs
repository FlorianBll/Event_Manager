using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager.Forms.User
{
    public partial class Form_CreateEdit_User : Form
    {
        #region variable

        private string _buttonName;

        #endregion

        #region get/set

        public string buttonName { get; set; }

        #endregion

        public Form_CreateEdit_User()
        {
            InitializeComponent();
        }

        private void enableButton()
        {
            bool isAllFieldFilled = textBox_Firstname.TextLength > 0 && textBox_Lastname.TextLength > 0 && textBox_Email.TextLength > 0 && textBox_Password.TextLength > 0 && textBox_PasswordCheck.TextLength > 0;

            if (isAllFieldFilled)
            {
                button_UserCreateEdit.Enabled = true;
            }
            else
            {
                button_UserCreateEdit.Enabled = false;
            }
        }

        private bool passwordCheck()
        {
            if (textBox_PasswordCheck.Text != textBox_PasswordCheck.Text)
            {
                MessageBox.Show("Both passwords entered is not identical. Please try again.", "Not same passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;            
            }
        }

        private void textBox_Firstname_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void textBox_Lastname_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void textBox_PasswordCheck_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void button_UserCreateEdit_Click(object sender, EventArgs e)
        {
            bool isAllFieldFilled = textBox_Firstname.TextLength > 0 && textBox_Lastname.TextLength > 0 && textBox_Email.TextLength > 0 && textBox_Password.TextLength > 0 && textBox_PasswordCheck.TextLength > 0;

            if (isAllFieldFilled && passwordCheck())
            {
                // Creation of user instance and add it into user list
            }
        }
    }
}
