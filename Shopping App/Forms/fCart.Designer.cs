namespace Shopping_App.Forms
{
    partial class fCart
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
            this.pControl = new System.Windows.Forms.Panel();
            this.btnCheckOut = new FontAwesome.Sharp.IconButton();
            this.pSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.flpCart = new System.Windows.Forms.FlowLayoutPanel();
            this.pControl.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.Controls.Add(this.btnCheckOut);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pControl.Location = new System.Drawing.Point(0, 600);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(1107, 68);
            this.pControl.TabIndex = 1;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheckOut.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnCheckOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheckOut.IconSize = 32;
            this.btnCheckOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckOut.Location = new System.Drawing.Point(446, 19);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCheckOut.Size = new System.Drawing.Size(184, 37);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // pSearch
            // 
            this.pSearch.Controls.Add(this.btnSearch);
            this.pSearch.Controls.Add(this.txbSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1107, 57);
            this.pSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.Location = new System.Drawing.Point(735, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearch.Size = new System.Drawing.Size(36, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearch.Location = new System.Drawing.Point(314, 8);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(415, 41);
            this.txbSearch.TabIndex = 0;
            this.txbSearch.TextChanged += new System.EventHandler(this.txbSearch_TextChanged);
            // 
            // flpCart
            // 
            this.flpCart.AutoScroll = true;
            this.flpCart.BackColor = System.Drawing.Color.Silver;
            this.flpCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpCart.Location = new System.Drawing.Point(0, 57);
            this.flpCart.Name = "flpCart";
            this.flpCart.Size = new System.Drawing.Size(1107, 543);
            this.flpCart.TabIndex = 3;
            // 
            // fCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.flpCart);
            this.Controls.Add(this.pSearch);
            this.Controls.Add(this.pControl);
            this.Name = "fCart";
            this.Text = "Cart";
            this.pControl.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Panel pSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.FlowLayoutPanel flpCart;
        private FontAwesome.Sharp.IconButton btnCheckOut;
    }
}