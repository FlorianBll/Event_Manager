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
    public partial class Form_Login : Form
    {
        #region variables

        private string _userName;

        #endregion

        #region get/set

        public string UserName { get; set; }

        #endregion

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            textBox_UserName.Text = UserName;
        }

        private bool IsFieldNotEmpty()
        {
            return textBox_UserName.TextLength > 0 && textBox_Password.TextLength > 0;
        }
        private void textBox_USerName_TextChanged(object sender, EventArgs e)
        {
            if (IsFieldNotEmpty())
            {
                textBox_UserName.Text = UserName;
            }
        }
    }
}
