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
            this.pLogo = new System.Windows.Forms.Panel();
            this.pTitleBar = new System.Windows.Forms.Panel();
            this.pDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icZoomIn = new FontAwesome.Sharp.IconPictureBox();
            this.icMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.icZoomOut = new FontAwesome.Sharp.IconPictureBox();
            this.icExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnContactUs = new FontAwesome.Sharp.IconButton();
            this.btnProfile = new FontAwesome.Sharp.IconButton();
            this.btnBlog = new FontAwesome.Sharp.IconButton();
            this.btnCart = new FontAwesome.Sharp.IconButton();
            this.btnShop = new FontAwesome.Sharp.IconButton();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            this.pTitleBar.SuspendLayout();
            this.pDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.pMenu.Controls.Add(this.btnSetting);
            this.pMenu.Controls.Add(this.btnContactUs);
            this.pMenu.Controls.Add(this.btnProfile);
            this.pMenu.Controls.Add(this.btnBlog);
            this.pMenu.Controls.Add(this.btnCart);
            this.pMenu.Controls.Add(this.btnShop);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(207, 553);
            this.pMenu.TabIndex = 0;
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(78)))));
            this.pLogo.Controls.Add(this.btnLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(207, 133);
            this.pLogo.TabIndex = 0;
            // 
            // pTitleBar
            // 
            this.pTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(78)))));
            this.pTitleBar.Controls.Add(this.icZoomIn);
            this.pTitleBar.Controls.Add(this.icMinimize);
            this.pTitleBar.Controls.Add(this.icZoomOut);
            this.pTitleBar.Controls.Add(this.icExit);
            this.pTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitleBar.Location = new System.Drawing.Point(207, 0);
            this.pTitleBar.Name = "pTitleBar";
            this.pTitleBar.Size = new System.Drawing.Size(875, 38);
            this.pTitleBar.TabIndex = 1;
            // 
            // pDesktop
            // 
            this.pDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.pDesktop.Controls.Add(this.pictureBox1);
            this.pDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktop.Location = new System.Drawing.Point(207, 38);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(875, 515);
            this.pDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pictureBox1.Image = global::Shopping_App.Properties.Resources.nobg_final_logo;
            this.pictureBox1.Location = new System.Drawing.Point(36, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // icZoomIn
            // 
            this.icZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.icZoomIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.icZoomIn.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.icZoomIn.IconColor = System.Drawing.Color.Gainsboro;
            this.icZoomIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icZoomIn.Location = new System.Drawing.Point(802, 3);
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
            this.icMinimize.BackColor = System.Drawing.Color.Transparent;
            this.icMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.icMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.icMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.icMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icMinimize.Location = new System.Drawing.Point(764, 3);
            this.icMinimize.Name = "icMinimize";
            this.icMinimize.Size = new System.Drawing.Size(32, 32);
            this.icMinimize.TabIndex = 4;
            this.icMinimize.TabStop = false;
            this.icMinimize.Click += new System.EventHandler(this.icMinimize_Click);
            // 
            // icZoomOut
            // 
            this.icZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.icZoomOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.icZoomOut.IconChar = FontAwesome.Sharp.IconChar.ExpandArrowsAlt;
            this.icZoomOut.IconColor = System.Drawing.Color.Gainsboro;
            this.icZoomOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icZoomOut.Location = new System.Drawing.Point(802, 3);
            this.icZoomOut.Name = "icZoomOut";
            this.icZoomOut.Size = new System.Drawing.Size(32, 32);
            this.icZoomOut.TabIndex = 3;
            this.icZoomOut.TabStop = false;
            this.icZoomOut.Click += new System.EventHandler(this.icZoomOut_Click);
            // 
            // icExit
            // 
            this.icExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExit.BackColor = System.Drawing.Color.Transparent;
            this.icExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.icExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.icExit.IconColor = System.Drawing.Color.Gainsboro;
            this.icExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icExit.Location = new System.Drawing.Point(840, 3);
            this.icExit.Name = "icExit";
            this.icExit.Size = new System.Drawing.Size(32, 32);
            this.icExit.TabIndex = 2;
            this.icExit.TabStop = false;
            this.icExit.Click += new System.EventHandler(this.icExit_Click);
            this.icExit.MouseLeave += new System.EventHandler(this.icExit_MouseLeave);
            this.icExit.MouseHover += new System.EventHandler(this.icExit_MouseHover);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 433);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetting.Size = new System.Drawing.Size(207, 60);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnContactUs
            // 
            this.btnContactUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactUs.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContactUs.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            this.btnContactUs.IconColor = System.Drawing.Color.Gainsboro;
            this.btnContactUs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnContactUs.IconSize = 32;
            this.btnContactUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactUs.Location = new System.Drawing.Point(0, 373);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnContactUs.Size = new System.Drawing.Size(207, 60);
            this.btnContactUs.TabIndex = 5;
            this.btnContactUs.Text = "Contact Us";
            this.btnContactUs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactUs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContactUs.UseVisualStyleBackColor = true;
            this.btnContactUs.Click += new System.EventHandler(this.btnMarketing_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnProfile.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProfile.IconSize = 32;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(0, 313);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnProfile.Size = new System.Drawing.Size(207, 60);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBlog
            // 
            this.btnBlog.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBlog.FlatAppearance.BorderSize = 0;
            this.btnBlog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlog.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBlog.IconChar = FontAwesome.Sharp.IconChar.Tag;
            this.btnBlog.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBlog.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBlog.IconSize = 32;
            this.btnBlog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlog.Location = new System.Drawing.Point(0, 253);
            this.btnBlog.Name = "btnBlog";
            this.btnBlog.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBlog.Size = new System.Drawing.Size(207, 60);
            this.btnBlog.TabIndex = 3;
            this.btnBlog.Text = "Blog";
            this.btnBlog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBlog.UseVisualStyleBackColor = true;
            this.btnBlog.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCart.IconSize = 32;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(0, 193);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCart.Size = new System.Drawing.Size(207, 60);
            this.btnCart.TabIndex = 2;
            this.btnCart.Text = "Cart";
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnShop
            // 
            this.btnShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShop.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShop.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnShop.IconColor = System.Drawing.Color.Gainsboro;
            this.btnShop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnShop.IconSize = 32;
            this.btnShop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Location = new System.Drawing.Point(0, 133);
            this.btnShop.Name = "btnShop";
            this.btnShop.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnShop.Size = new System.Drawing.Size(207, 60);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "Shop";
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShop.UseVisualStyleBackColor = true;
            this.btnShop.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Image = global::Shopping_App.Properties.Resources.nobg_final_logo;
            this.btnLogo.Location = new System.Drawing.Point(3, 3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(198, 124);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogo.TabIndex = 0;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // fMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.pTitleBar);
            this.Controls.Add(this.pMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.pMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pTitleBar.ResumeLayout(false);
            this.pDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icZoomOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btnShop;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnContactUs;
        private FontAwesome.Sharp.IconButton btnProfile;
        private FontAwesome.Sharp.IconButton btnBlog;
        private FontAwesome.Sharp.IconButton btnCart;
        private System.Windows.Forms.Panel pTitleBar;
        private System.Windows.Forms.Panel pDesktop;
        private FontAwesome.Sharp.IconPictureBox icMinimize;
        private FontAwesome.Sharp.IconPictureBox icZoomOut;
        private FontAwesome.Sharp.IconPictureBox icExit;
        private FontAwesome.Sharp.IconPictureBox icZoomIn;
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

