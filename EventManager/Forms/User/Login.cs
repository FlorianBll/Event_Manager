﻿using System;
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
    /// Instance of the Windows Form “Login”.
    /// </summary>
    public partial class Form_Login : Form
    {
        #region get/set

        public string UserName { get; set; }

        public int UserIndex { get; set; }
        private User user { get; set; }
        public Form_Authentification Auth { get; set; }

        #endregion

        public Form_Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the User instance with is specific index.
        /// </summary>
        /// <returns>The user instance.</returns>
        public User GetUser()
        {
            return UserList.Users[UserIndex];
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            textBox_UserName.Text = UserName;
        }

        /// <summary>
        /// Check if the form's field are empty.
        /// </summary>
        /// <returns>True if fields are empty, otherwise false.</returns>
        private bool IsFieldNotEmpty()
        {
            return textBox_UserName.TextLength > 0 && textBox_Password.TextLength > 0;
        }
        private void textBox_USerName_TextChanged(object sender, EventArgs e)
        {
            if (IsFieldNotEmpty())
            {
                button_Login.Enabled = true;
            }
            else
            {
                button_Login.Enabled = false;
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (IsFieldNotEmpty())
            {
                button_Login.Enabled = true;
            }
            else
            {
                button_Login.Enabled = false;
            }
        }

        private bool CheckPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                string hashedPassword = Convert.ToBase64String(hashBytes);

                user = UserList.Users[UserIndex];

                if (user.EncryptedPassword == hashedPassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if (IsFieldNotEmpty() && CheckPassword(textBox_Password.Text))
            {
                UserLogged.User = GetUser();

                Console.WriteLine($"User '{GetUser().FirstName} {GetUser().LastName}' connected !");

                Auth.Close();
                Auth.Dispose();

                Close();
                Dispose();
            }
            else
            {
                MessageBox.Show("You have entered the wrong password. Please try again !", "Wrong password typed", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                textBox_Password.Clear();
            }
        }
    }
}
