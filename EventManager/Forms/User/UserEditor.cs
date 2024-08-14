using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManager
{
    public partial class Form_UserEditor : Form
    {
        #region variable

        private string _buttonName;

        #endregion

        #region get/set

        public string buttonName { get; set; }

        #endregion

        public Form_UserEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Create a user and store it into a list of users using UserList class.
        /// </summary>
        private void CreateUser()
        {
            bool isUserExist = false;

            if (UserList.users.Count >= 0)
            {
                foreach (User user in UserList.users)
                {
                    if (user.firstName == textBox_Firstname.Text && user.lastName == textBox_Lastname.Text)
                    {
                        Console.WriteLine("The user already exist");
                        isUserExist = true;
                    }
                    else
                    {
                        isUserExist = false;
                    }
                }
            }

            if (!isUserExist)
            {
                string firstName = textBox_Firstname.Text;
                string lastName = textBox_Lastname.Text;
                string sector = comboBox_Sector.Items[comboBox_Sector.SelectedIndex].ToString();
                string email = textBox_Email.Text;
                string password = EncryptPassword(textBox_Password.Text);

                UserList.users.Add(new User(firstName, lastName, sector, email, password));
            }
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
        /// <summary>
        /// Check if both passwords fields are same.
        /// </summary>
        /// <returns>
        /// True is identical. Otherwise false.
        /// </returns>
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
        /// <summary>
        /// Encrypt a password.
        /// </summary>
        /// <param name="password">The password to encrypt</param>
        /// <returns>The hashed password.</returns>
        private String EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                string hashedPassword = BitConverter.ToString(hashBytes);

                return hashedPassword;
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
