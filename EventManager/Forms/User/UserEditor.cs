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
    /// <summary>
    /// Instance of the Windows Form "UserEditor".
    /// </summary>
    public partial class Form_UserEditor : Form
    {
        #region variable

        private string _buttonName;
        private int _currentInd;

        #endregion

        #region get/set

        public string ButtonName { get; set; }
        public int CurrentInd { get; set; }

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

            if (UserList.users != null &&  UserList.users.Count > 0)
            {
                foreach (User user in UserList.users)
                {
                    if (user.FirstName == textBox_Firstname.Text && user.LastName == textBox_Lastname.Text)
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
                string rawPasswd = textBox_Password.Text;
                string encryptPasswd = EncryptPassword(textBox_Password.Text);

                UserList.users.Add(new User(firstName, lastName, sector, email, rawPasswd, encryptPasswd));

                if (UserList.users.Count > 0)
                {
                    Console.WriteLine("User added !");
                }

                Close();
            }
            else
            {
                MessageBox.Show("The user you have entered already exist !", "User already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Get User instance correponding to is index.
        /// </summary>
        /// <returns>The user matching to the current index.</returns>
        private User GetUser()
        {
            if (CurrentInd != -1)
            {
                return UserList.users[CurrentInd];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Edit an existing user present on the UserList.
        /// </summary>
        private void EditUser()
        {
            User u = GetUser();

            bool isUserAlreadyExist = false;

            foreach (User user in UserList.users)
            {
                if (UserList.users.IndexOf(user) != CurrentInd && user.FirstName == textBox_Firstname.Text && user.LastName == textBox_Lastname.Text)
                {
                    isUserAlreadyExist = true;
                }
            }

            if (u != null && !isUserAlreadyExist)
            {
                u.FirstName = textBox_Firstname.Text;
                u.LastName = textBox_Lastname.Text;

                u.Sector = comboBox_Sector.Items[comboBox_Sector.SelectedIndex].ToString();

                textBox_Email.Text = u.Email;

                UserList.users[CurrentInd] = u;

                if (UserList.users.IndexOf(u) != -1)
                {
                    Console.WriteLine($"User '{u.FirstName} {u.LastName}' has been edited");
                }

                Close();
            }
        }
        /// <summary>
        /// Clear all fields.
        /// </summary>
        private void EmptyFields()
        {
            textBox_Firstname.Text = string.Empty;
            textBox_Lastname.Text= string.Empty;
            comboBox_Sector.SelectedIndex = 0;

            textBox_Email.Text = string.Empty;

            textBox_Password.Text = string.Empty;
            textBox_PasswordCheck.Text = string.Empty;
        }

        /// <summary>
        /// Refill all form's field.
        /// </summary>
        private void RetrieveData()
        {
            User u = GetUser();

            if (u != null)
            {
                textBox_Firstname.Text = u.FirstName;
                textBox_Lastname.Text = u.LastName;
                
                comboBox_Sector.Text = u.Sector;

                textBox_Email.Text = u.Email;

                textBox_Password.Text = u.RawPassword;
                textBox_PasswordCheck.Text = u.RawPassword;
            }
        }
        /// <summary>
        /// Enable Create/Edit button if all fields are not empty.
        /// </summary>
        private void EnableButton()
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
            if (textBox_Password.Text != textBox_PasswordCheck.Text)
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
            EnableButton();
        }

        private void textBox_Lastname_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void textBox_Email_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void textBox_PasswordCheck_TextChanged(object sender, EventArgs e)
        {
            EnableButton();
        }

        private void button_UserCreateEdit_Click(object sender, EventArgs e)
        {
            bool isAllFieldFilled = textBox_Firstname.TextLength > 0 && textBox_Lastname.TextLength > 0 && textBox_Email.TextLength > 0 && textBox_Password.TextLength > 0 && textBox_PasswordCheck.TextLength > 0;

            if (isAllFieldFilled && passwordCheck())
            {
                if (ButtonName == "Create User")
                {
                    CreateUser();
                }
                else
                {
                    EditUser();
                }
            }
        }

        private void Form_UserEditor_Load(object sender, EventArgs e)
        {
            button_UserCreateEdit.Text = ButtonName;

            if (ButtonName == "Create User")
            {
                EmptyFields();
            }
            else
            {
                RetrieveData();
            }
        }
    }
}
