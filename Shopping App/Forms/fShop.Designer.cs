﻿namespace Shopping_App.Forms
{
    partial class fShop
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
            this.pSelectBar = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pSelectBar
            // 
            this.pSelectBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSelectBar.Location = new System.Drawing.Point(0, 0);
            this.pSelectBar.Name = "pSelectBar";
            this.pSelectBar.Size = new System.Drawing.Size(871, 58);
            this.pSelectBar.TabIndex = 0;
            // 
            // fShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 484);
            this.Controls.Add(this.pSelectBar);
            this.Name = "fShop";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSelectBar;
    }
}