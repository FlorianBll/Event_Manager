﻿namespace EventManager
{
    partial class Form_DeveloperToolbox
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
            this.button_NotifPush = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NotifPush
            // 
            this.button_NotifPush.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NotifPush.Location = new System.Drawing.Point(12, 12);
            this.button_NotifPush.Name = "button_NotifPush";
            this.button_NotifPush.Size = new System.Drawing.Size(276, 63);
            this.button_NotifPush.TabIndex = 0;
            this.button_NotifPush.Text = "Test Notification Push";
            this.button_NotifPush.UseVisualStyleBackColor = true;
            // 
            // Form_DeveloperToolbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 269);
            this.Controls.Add(this.button_NotifPush);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(316, 308);
            this.MinimumSize = new System.Drawing.Size(316, 308);
            this.Name = "Form_DeveloperToolbox";
            this.Text = "Developer Toolbox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NotifPush;
    }
}