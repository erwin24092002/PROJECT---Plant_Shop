﻿namespace Shopping_App.Forms
{
    partial class fBill
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
            this.rpvBill = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pControl = new System.Windows.Forms.Panel();
            this.icExit = new FontAwesome.Sharp.IconPictureBox();
            this.pControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvBill
            // 
            this.rpvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBill.Location = new System.Drawing.Point(0, 0);
            this.rpvBill.Name = "rpvBill";
            this.rpvBill.ServerReport.BearerToken = null;
            this.rpvBill.Size = new System.Drawing.Size(843, 630);
            this.rpvBill.TabIndex = 0;
            // 
            // pControl
            // 
            this.pControl.Controls.Add(this.icExit);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl.Location = new System.Drawing.Point(0, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(843, 33);
            this.pControl.TabIndex = 1;
            // 
            // icExit
            // 
            this.icExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExit.BackColor = System.Drawing.Color.Transparent;
            this.icExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.icExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.icExit.IconColor = System.Drawing.Color.Gainsboro;
            this.icExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icExit.Location = new System.Drawing.Point(811, 0);
            this.icExit.Name = "icExit";
            this.icExit.Size = new System.Drawing.Size(32, 32);
            this.icExit.TabIndex = 3;
            this.icExit.TabStop = false;
            this.icExit.Click += new System.EventHandler(this.icExit_Click);
            this.icExit.MouseLeave += new System.EventHandler(this.icExit_MouseLeave);
            this.icExit.MouseHover += new System.EventHandler(this.icExit_MouseHover);
            // 
            // fBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 630);
            this.Controls.Add(this.pControl);
            this.Controls.Add(this.rpvBill);
            this.Name = "fBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBill";
            this.Load += new System.EventHandler(this.fBill_Load);
            this.pControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvBill;
        private System.Windows.Forms.Panel pControl;
        private FontAwesome.Sharp.IconPictureBox icExit;
    }
}