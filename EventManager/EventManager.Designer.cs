namespace EventManager
{
    partial class Form_EventManager
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_Events = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_CreateEvent = new System.Windows.Forms.Button();
            this.button_DeleteEvent = new System.Windows.Forms.Button();
            this.textBox_SearchEventName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_SearchEvent = new System.Windows.Forms.Button();
            this.button_EditEvent = new System.Windows.Forms.Button();
            this.button_DevMode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Events
            // 
            this.listBox_Events.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_Events.FormattingEnabled = true;
            this.listBox_Events.Location = new System.Drawing.Point(15, 143);
            this.listBox_Events.Name = "listBox_Events";
            this.listBox_Events.Size = new System.Drawing.Size(472, 251);
            this.listBox_Events.TabIndex = 0;
            this.listBox_Events.SelectedIndexChanged += new System.EventHandler(this.listBox_Events_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Events registered :";
            // 
            // button_CreateEvent
            // 
            this.button_CreateEvent.Location = new System.Drawing.Point(15, 12);
            this.button_CreateEvent.Name = "button_CreateEvent";
            this.button_CreateEvent.Size = new System.Drawing.Size(126, 23);
            this.button_CreateEvent.TabIndex = 2;
            this.button_CreateEvent.Text = "Create New Event";
            this.button_CreateEvent.UseVisualStyleBackColor = true;
            this.button_CreateEvent.Click += new System.EventHandler(this.button_CreateEvent_Click);
            // 
            // button_DeleteEvent
            // 
            this.button_DeleteEvent.Enabled = false;
            this.button_DeleteEvent.Location = new System.Drawing.Point(15, 70);
            this.button_DeleteEvent.Name = "button_DeleteEvent";
            this.button_DeleteEvent.Size = new System.Drawing.Size(126, 23);
            this.button_DeleteEvent.TabIndex = 3;
            this.button_DeleteEvent.Text = "Delete Event";
            this.button_DeleteEvent.UseVisualStyleBackColor = true;
            this.button_DeleteEvent.Click += new System.EventHandler(this.button_DeleteEvent_Click);
            // 
            // textBox_SearchEventName
            // 
            this.textBox_SearchEventName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_SearchEventName.Location = new System.Drawing.Point(82, 30);
            this.textBox_SearchEventName.Name = "textBox_SearchEventName";
            this.textBox_SearchEventName.Size = new System.Drawing.Size(151, 20);
            this.textBox_SearchEventName.TabIndex = 4;
            this.textBox_SearchEventName.TextChanged += new System.EventHandler(this.textBox_SearchEventName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Event name :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_SearchEvent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_SearchEventName);
            this.groupBox1.Location = new System.Drawing.Point(182, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // button_SearchEvent
            // 
            this.button_SearchEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SearchEvent.Enabled = false;
            this.button_SearchEvent.Location = new System.Drawing.Point(239, 29);
            this.button_SearchEvent.Name = "button_SearchEvent";
            this.button_SearchEvent.Size = new System.Drawing.Size(50, 23);
            this.button_SearchEvent.TabIndex = 6;
            this.button_SearchEvent.Text = "OK";
            this.button_SearchEvent.UseVisualStyleBackColor = true;
            this.button_SearchEvent.Click += new System.EventHandler(this.button_SearchEvent_Click);
            // 
            // button_EditEvent
            // 
            this.button_EditEvent.Enabled = false;
            this.button_EditEvent.Location = new System.Drawing.Point(15, 41);
            this.button_EditEvent.Name = "button_EditEvent";
            this.button_EditEvent.Size = new System.Drawing.Size(126, 23);
            this.button_EditEvent.TabIndex = 7;
            this.button_EditEvent.Text = "Edit Event";
            this.button_EditEvent.UseVisualStyleBackColor = true;
            this.button_EditEvent.Click += new System.EventHandler(this.button_EditEvent_Click);
            // 
            // button_DevMode
            // 
            this.button_DevMode.Location = new System.Drawing.Point(297, 105);
            this.button_DevMode.Name = "button_DevMode";
            this.button_DevMode.Size = new System.Drawing.Size(118, 23);
            this.button_DevMode.TabIndex = 8;
            this.button_DevMode.Text = "Developer Toolbox";
            this.button_DevMode.UseVisualStyleBackColor = true;
            this.button_DevMode.Visible = false;
            this.button_DevMode.Click += new System.EventHandler(this.button_DevMode_Click);
            // 
            // Form_EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(502, 406);
            this.Controls.Add(this.button_DevMode);
            this.Controls.Add(this.button_EditEvent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_DeleteEvent);
            this.Controls.Add(this.button_CreateEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Events);
            this.MinimumSize = new System.Drawing.Size(518, 445);
            this.Name = "Form_EventManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event Manager";
            this.Activated += new System.EventHandler(this.Form_EventManager_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Events;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateEvent;
        private System.Windows.Forms.Button button_DeleteEvent;
        private System.Windows.Forms.TextBox textBox_SearchEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_SearchEvent;
        private System.Windows.Forms.Button button_EditEvent;
        private System.Windows.Forms.Button button_DevMode;
    }
}

