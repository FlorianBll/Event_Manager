namespace EventManager
{
    partial class Form_EventEditor
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
            this.textBox_EventName = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_StartEvent = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox_EventDescription = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_CreateEditEvent = new System.Windows.Forms.Button();
            this.dateTimePicker_EndEvent = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Reminder = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Name :";
            // 
            // textBox_EventName
            // 
            this.textBox_EventName.Location = new System.Drawing.Point(93, 12);
            this.textBox_EventName.Name = "textBox_EventName";
            this.textBox_EventName.Size = new System.Drawing.Size(121, 20);
            this.textBox_EventName.TabIndex = 1;
            this.textBox_EventName.TextChanged += new System.EventHandler(this.textBox_EventName_TextChanged);
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(93, 41);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(121, 20);
            this.textBox_Author.TabIndex = 3;
            this.textBox_Author.TextChanged += new System.EventHandler(this.textBox_Author_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author :";
            // 
            // dateTimePicker_StartEvent
            // 
            this.dateTimePicker_StartEvent.Location = new System.Drawing.Point(93, 73);
            this.dateTimePicker_StartEvent.Name = "dateTimePicker_StartEvent";
            this.dateTimePicker_StartEvent.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_StartEvent.TabIndex = 4;
            this.dateTimePicker_StartEvent.Value = new System.DateTime(2024, 8, 6, 14, 10, 40, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Starting Date :";
            // 
            // richTextBox_EventDescription
            // 
            this.richTextBox_EventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_EventDescription.Location = new System.Drawing.Point(93, 135);
            this.richTextBox_EventDescription.Name = "richTextBox_EventDescription";
            this.richTextBox_EventDescription.Size = new System.Drawing.Size(455, 294);
            this.richTextBox_EventDescription.TabIndex = 6;
            this.richTextBox_EventDescription.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description :";
            // 
            // button_CreateEditEvent
            // 
            this.button_CreateEditEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_CreateEditEvent.Enabled = false;
            this.button_CreateEditEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateEditEvent.Location = new System.Drawing.Point(335, 15);
            this.button_CreateEditEvent.Name = "button_CreateEditEvent";
            this.button_CreateEditEvent.Size = new System.Drawing.Size(118, 46);
            this.button_CreateEditEvent.TabIndex = 8;
            this.button_CreateEditEvent.Text = "Create Event";
            this.button_CreateEditEvent.UseVisualStyleBackColor = true;
            this.button_CreateEditEvent.Click += new System.EventHandler(this.button_CreateEditEvent_Click);
            // 
            // dateTimePicker_EndEvent
            // 
            this.dateTimePicker_EndEvent.Location = new System.Drawing.Point(93, 99);
            this.dateTimePicker_EndEvent.Name = "dateTimePicker_EndEvent";
            this.dateTimePicker_EndEvent.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_EndEvent.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ending Date :";
            // 
            // comboBox_Reminder
            // 
            this.comboBox_Reminder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Reminder.FormattingEnabled = true;
            this.comboBox_Reminder.Items.AddRange(new object[] {
            "5 min",
            "10 min",
            "30 min",
            "1 hour",
            "2 hour",
            "1 day"});
            this.comboBox_Reminder.Location = new System.Drawing.Point(396, 96);
            this.comboBox_Reminder.Name = "comboBox_Reminder";
            this.comboBox_Reminder.Size = new System.Drawing.Size(152, 21);
            this.comboBox_Reminder.TabIndex = 11;
            this.comboBox_Reminder.Text = "5 min";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Reminder :";
            // 
            // Form_EventEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Reminder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_EndEvent);
            this.Controls.Add(this.button_CreateEditEvent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox_EventDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_StartEvent);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_EventName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(576, 480);
            this.Name = "Form_EventEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Event Editor";
            this.Load += new System.EventHandler(this.Form_EventEditor_Load);
            // this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_EventName;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartEvent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox_EventDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_CreateEditEvent;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Reminder;
        private System.Windows.Forms.Label label6;
    }
}