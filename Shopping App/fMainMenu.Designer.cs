namespace Shopping_App
{
    partial class fMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMainMenu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnMarketing = new FontAwesome.Sharp.IconButton();
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.icZoomIn = new FontAwesome.Sharp.IconPictureBox();
            this.icMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.icZoomOut = new FontAwesome.Sharp.IconPictureBox();
            this.icExit = new FontAwesome.Sharp.IconPictureBox();
            this.lbTitleChileForm = new System.Windows.Forms.Label();
            this.pShadow = new System.Windows.Forms.Panel();
            this.pDesktop = new System.Windows.Forms.Panel();
            this.pMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.pTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pMenu.Controls.Add(this.btnSetting);
            this.pMenu.Controls.Add(this.btnMarketing);
            this.pMenu.Controls.Add(this.btnCustomer);
            this.pMenu.Controls.Add(this.btnProduct);
            this.pMenu.Controls.Add(this.btnOrder);
            this.pMenu.Controls.Add(this.btnDashboard);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(230, 569);
            this.pMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 402);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(230, 60);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMarketing
            // 
            this.btnMarketing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarketing.FlatAppearance.BorderSize = 0;
            this.btnMarketing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarketing.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMarketing.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnMarketing.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMarketing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMarketing.IconSize = 32;
            this.btnMarketing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarketing.Location = new System.Drawing.Point(0, 342);
            this.btnMarketing.Name = "btnMarketing";
            this.btnMarketing.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMarketing.Size = new System.Drawing.Size(230, 60);
            this.btnMarketing.TabIndex = 5;
            this.btnMarketing.Text = "Marketing";
            this.btnMarketing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarketing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarketing.UseVisualStyleBackColor = true;
            this.btnMarketing.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.IconSize = 32;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(0, 282);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomer.Size = new System.Drawing.Size(230, 60);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.IconSize = 32;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 222);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProduct.Size = new System.Drawing.Size(230, 60);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 32;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 162);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrder.Size = new System.Drawing.Size(230, 60);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Orders";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 102);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDashboard.Size = new System.Drawing.Size(230, 60);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.btnLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(230, 102);
            this.pLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Image = global::Shopping_App.Properties.Resources.nobd_logo;
            this.btnLogo.Location = new System.Drawing.Point(9, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(212, 95);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pTitleBar.Controls.Add(this.icZoomIn);
            this.pTitleBar.Controls.Add(this.icMinimize);
            this.pTitleBar.Controls.Add(this.icZoomOut);
            this.pTitleBar.Controls.Add(this.icExit);
            this.pTitleBar.Controls.Add(this.lbTitleChileForm);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(230, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(889, 61);
            this.pTitleBar.TabIndex = 1;
            // 
            // icZoomIn
            // 
            this.icZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icZoomIn.ForeColor = System.Drawing.Color.MediumPurple;
            this.icZoomIn.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.icZoomIn.IconColor = System.Drawing.Color.MediumPurple;
            this.icZoomIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icZoomIn.Location = new System.Drawing.Point(816, 3);
            this.icZoomIn.Name = "icZoomIn";
            this.icZoomIn.Size = new System.Drawing.Size(32, 32);
            this.icZoomIn.TabIndex = 5;
            this.icZoomIn.TabStop = false;
            this.icZoomIn.Visible = false;
            this.icZoomIn.Click += new System.EventHandler(this.icZoomIn_Click);
            // 
            // icMinimize
            // 
            this.icMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icMinimize.ForeColor = System.Drawing.Color.MediumPurple;
            this.icMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.icMinimize.IconColor = System.Drawing.Color.MediumPurple;
            this.icMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMinimize.Location = new System.Drawing.Point(778, 3);
            this.icMinimize.Name = "icMinimize";
            this.icMinimize.Size = new System.Drawing.Size(32, 32);
            this.icMinimize.TabIndex = 4;
            this.icMinimize.TabStop = false;
            this.icMinimize.Click += new System.EventHandler(this.icMinimize_Click);
            // 
            // icZoomOut
            // 
            this.icZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icZoomOut.ForeColor = System.Drawing.Color.MediumPurple;
            this.icZoomOut.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.icZoomOut.IconColor = System.Drawing.Color.MediumPurple;
            this.icZoomOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icZoomOut.Location = new System.Drawing.Point(816, 3);
            this.icZoomOut.Name = "icZoomOut";
            this.icZoomOut.Size = new System.Drawing.Size(32, 32);
            this.icZoomOut.TabIndex = 3;
            this.icZoomOut.TabStop = false;
            this.icZoomOut.Click += new System.EventHandler(this.icZoomOut_Click);
            // 
            // icExit
            // 
            this.icExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icExit.ForeColor = System.Drawing.Color.MediumPurple;
            this.icExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.icExit.IconColor = System.Drawing.Color.MediumPurple;
            this.icExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icExit.Location = new System.Drawing.Point(854, 3);
            this.icExit.Name = "icExit";
            this.icExit.Size = new System.Drawing.Size(32, 32);
            this.icExit.TabIndex = 2;
            this.icExit.TabStop = false;
            this.icExit.Click += new System.EventHandler(this.icExit_Click);
            // 
            // lbTitleChileForm
            // 
            this.lbTitleChileForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTitleChileForm.AutoSize = true;
            this.lbTitleChileForm.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleChileForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTitleChileForm.Location = new System.Drawing.Point(374, 9);
            this.lbTitleChileForm.Name = "lbTitleChileForm";
            this.lbTitleChileForm.Size = new System.Drawing.Size(148, 50);
            this.lbTitleChileForm.TabIndex = 1;
            this.lbTitleChileForm.Text = "Home";
            this.lbTitleChileForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitleChileForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbTitleChileForm_MouseDown);
            // 
            // pShadow
            // 
            this.pShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pShadow.Location = new System.Drawing.Point(230, 61);
            this.pShadow.Name = "pShadow";
            this.pShadow.Size = new System.Drawing.Size(889, 9);
            this.pShadow.TabIndex = 2;
            // 
            // pDesktop
            // 
            this.pDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktop.Location = new System.Drawing.Point(230, 70);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(889, 499);
            this.pDesktop.TabIndex = 3;
            // 
            // fMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 569);
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.pShadow);
            this.Controls.Add(this.pTitleBar);
            this.Controls.Add(this.pMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.pMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.pTitleBar.ResumeLayout(false);
            this.pTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnMarketing;
        private FontAwesome.Sharp.IconButton btnCustomer;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnOrder;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Label lbTitleChileForm;
        private System.Windows.Forms.Panel pShadow;
        private System.Windows.Forms.Panel pDesktop;
        private FontAwesome.Sharp.IconPictureBox icMinimize;
        private FontAwesome.Sharp.IconPictureBox icZoomOut;
        private FontAwesome.Sharp.IconPictureBox icExit;
        private FontAwesome.Sharp.IconPictureBox icZoomIn;
    }
}

