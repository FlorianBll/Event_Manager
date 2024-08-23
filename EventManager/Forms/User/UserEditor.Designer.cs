namespace EventManager
{
    partial class Form_UserEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Firstname = new System.Windows.Forms.TextBox();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Sector = new System.Windows.Forms.ComboBox();
            this.button_UserCreateEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_PasswordCheck = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "firstname :";
            // 
            // textBox_Firstname
            // 
            this.textBox_Firstname.Location = new System.Drawing.Point(67, 22);
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Firstname.TabIndex = 1;
            this.textBox_Firstname.TextChanged += new System.EventHandler(this.textBox_Firstname_TextChanged);
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.Location = new System.Drawing.Point(67, 48);
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(100, 20);
            this.textBox_Lastname.TabIndex = 3;
            this.textBox_Lastname.TextChanged += new System.EventHandler(this.textBox_Lastname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "lastname :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "sector :";
            // 
            // comboBox_Sector
            // 
            this.comboBox_Sector.FormattingEnabled = true;
            this.comboBox_Sector.Items.AddRange(new object[] {
            "Cepiere",
            "Brombach",
            "Blagnac"});
            this.comboBox_Sector.Location = new System.Drawing.Point(67, 73);
            this.comboBox_Sector.Name = "comboBox_Sector";
            this.comboBox_Sector.Size = new System.Drawing.Size(100, 21);
            this.comboBox_Sector.TabIndex = 5;
            this.comboBox_Sector.Text = "Cepiere";
            // 
            // button_UserCreateEdit
            // 
            this.button_UserCreateEdit.Enabled = false;
            this.button_UserCreateEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button_UserCreateEdit.Location = new System.Drawing.Point(244, 20);
            this.button_UserCreateEdit.Name = "button_UserCreateEdit";
            this.button_UserCreateEdit.Size = new System.Drawing.Size(118, 46);
            this.button_UserCreateEdit.TabIndex = 6;
            this.button_UserCreateEdit.Text = "Create Profile";
            this.button_UserCreateEdit.UseVisualStyleBackColor = true;
            this.button_UserCreateEdit.Click += new System.EventHandler(this.button_UserCreateEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_Sector);
            this.groupBox1.Controls.Add(this.textBox_Firstname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_Lastname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_PasswordCheck);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Password);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Email);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 113);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Authentification";
            // 
            // textBox_PasswordCheck
            // 
            this.textBox_PasswordCheck.Location = new System.Drawing.Point(107, 75);
            this.textBox_PasswordCheck.Name = "textBox_PasswordCheck";
            this.textBox_PasswordCheck.Size = new System.Drawing.Size(237, 20);
            this.textBox_PasswordCheck.TabIndex = 5;
            this.textBox_PasswordCheck.UseSystemPasswordChar = true;
            this.textBox_PasswordCheck.TextChanged += new System.EventHandler(this.textBox_PasswordCheck_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "confirm password :";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(67, 49);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(277, 20);
            this.textBox_Password.TabIndex = 3;
            this.textBox_Password.UseSystemPasswordChar = true;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "password :";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(67, 23);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(277, 20);
            this.textBox_Email.TabIndex = 1;
            this.textBox_Email.TextChanged += new System.EventHandler(this.textBox_Email_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "email :";
            // 
            // Form_UserEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_UserCreateEdit);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(390, 303);
            this.MinimumSize = new System.Drawing.Size(390, 303);
            this.Name = "Form_UserEditor";
            this.Text = "CreateEdit_User";
            this.Load += new System.EventHandler(this.Form_UserEditor_Load);
            this.groupBox1.ResumeLayout(true);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(true);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(true);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Firstname;
        private System.Windows.Forms.TextBox textBox_Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Sector;
        private System.Windows.Forms.Button button_UserCreateEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_PasswordCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label4;
    }
}