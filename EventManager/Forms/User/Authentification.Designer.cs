namespace EventManager
{
    partial class Form_Authentification
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
            this.button_UserConnect = new System.Windows.Forms.Button();
            this.button_UserEdit = new System.Windows.Forms.Button();
            this.listBox_ProfileList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_UserDelete = new System.Windows.Forms.Button();
            this.button_UserCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_UserConnect
            // 
            this.button_UserConnect.Enabled = false;
            this.button_UserConnect.Location = new System.Drawing.Point(71, 34);
            this.button_UserConnect.Name = "button_UserConnect";
            this.button_UserConnect.Size = new System.Drawing.Size(269, 36);
            this.button_UserConnect.TabIndex = 0;
            this.button_UserConnect.Text = "Connect";
            this.button_UserConnect.UseVisualStyleBackColor = true;
            // 
            // button_UserEdit
            // 
            this.button_UserEdit.Enabled = false;
            this.button_UserEdit.Location = new System.Drawing.Point(184, 76);
            this.button_UserEdit.Name = "button_UserEdit";
            this.button_UserEdit.Size = new System.Drawing.Size(70, 36);
            this.button_UserEdit.TabIndex = 1;
            this.button_UserEdit.Text = "Edit Profile";
            this.button_UserEdit.UseVisualStyleBackColor = true;
            this.button_UserEdit.Click += new System.EventHandler(this.button_UserEdit_Click);
            // 
            // listBox_ProfileList
            // 
            this.listBox_ProfileList.Enabled = false;
            this.listBox_ProfileList.FormattingEnabled = true;
            this.listBox_ProfileList.Location = new System.Drawing.Point(12, 153);
            this.listBox_ProfileList.Name = "listBox_ProfileList";
            this.listBox_ProfileList.Size = new System.Drawing.Size(401, 173);
            this.listBox_ProfileList.TabIndex = 2;
            this.listBox_ProfileList.SelectedIndexChanged += new System.EventHandler(this.listBox_ProfileList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Exisitng Profiles";
            // 
            // button_UserDelete
            // 
            this.button_UserDelete.Enabled = false;
            this.button_UserDelete.Location = new System.Drawing.Point(260, 76);
            this.button_UserDelete.Name = "button_UserDelete";
            this.button_UserDelete.Size = new System.Drawing.Size(80, 36);
            this.button_UserDelete.TabIndex = 4;
            this.button_UserDelete.Text = "Delete Profile";
            this.button_UserDelete.UseVisualStyleBackColor = true;
            // 
            // button_UserCreate
            // 
            this.button_UserCreate.Location = new System.Drawing.Point(71, 76);
            this.button_UserCreate.Name = "button_UserCreate";
            this.button_UserCreate.Size = new System.Drawing.Size(107, 36);
            this.button_UserCreate.TabIndex = 5;
            this.button_UserCreate.Text = "Create New Profile";
            this.button_UserCreate.UseVisualStyleBackColor = true;
            this.button_UserCreate.Click += new System.EventHandler(this.button_UserCreate_Click);
            // 
            // Form_Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 340);
            this.Controls.Add(this.button_UserCreate);
            this.Controls.Add(this.button_UserDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_ProfileList);
            this.Controls.Add(this.button_UserEdit);
            this.Controls.Add(this.button_UserConnect);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(441, 379);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(441, 379);
            this.Name = "Form_Authentification";
            this.Text = "Authentification Panel";
            this.Activated += new System.EventHandler(this.Form_Authentification_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_UserConnect;
        private System.Windows.Forms.Button button_UserEdit;
        private System.Windows.Forms.ListBox listBox_ProfileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_UserDelete;
        private System.Windows.Forms.Button button_UserCreate;
    }
}