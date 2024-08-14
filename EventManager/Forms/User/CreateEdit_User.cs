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
    public partial class CreateEdit_User : Form
    {
        #region variable

        private string _buttonName;

        #endregion

        #region get/set

        public string buttonName { get; set; }

        #endregion

        public CreateEdit_User()
        {
            InitializeComponent();
        }
    }
}
