﻿namespace AffairsSystem
{
    partial class LogIn
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
            this.textBoxspNr = new System.Windows.Forms.TextBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxspNr
            // 
            this.textBoxspNr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxspNr.Location = new System.Drawing.Point(149, 273);
            this.textBoxspNr.Name = "textBoxspNr";
            this.textBoxspNr.Size = new System.Drawing.Size(100, 20);
            this.textBoxspNr.TabIndex = 1;
            this.textBoxspNr.UseSystemPasswordChar = true;
            this.textBoxspNr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxspNr_KeyPress);
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(162, 297);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(75, 23);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AffairsSystem.Properties.Resources.loginpicture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(398, 344);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.textBoxspNr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LogIn_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxspNr;
        private System.Windows.Forms.Button btnLogIn;
    }
}