namespace Shopping_App.Forms
{
    partial class fProfile
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
            this.flpBill = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpBill
            // 
            this.flpBill.AutoScroll = true;
            this.flpBill.BackColor = System.Drawing.Color.Silver;
            this.flpBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBill.Location = new System.Drawing.Point(0, 0);
            this.flpBill.Name = "flpBill";
            this.flpBill.Size = new System.Drawing.Size(857, 468);
            this.flpBill.TabIndex = 4;
            // 
            // fProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 468);
            this.Controls.Add(this.flpBill);
            this.Name = "fProfile";
            this.Text = "Customer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpBill;
    }
}