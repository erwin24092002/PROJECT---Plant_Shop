namespace Shopping_App.Forms
{
    partial class fPlant
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
            this.icExit = new FontAwesome.Sharp.IconPictureBox();
            this.pPlantPicture = new System.Windows.Forms.Panel();
            this.ptbPlant = new System.Windows.Forms.PictureBox();
            this.pPlantName = new System.Windows.Forms.Panel();
            this.lbPlantName = new System.Windows.Forms.Label();
            this.pControl2 = new System.Windows.Forms.Panel();
            this.btnReview = new FontAwesome.Sharp.IconButton();
            this.btnDescription = new FontAwesome.Sharp.IconButton();
            this.pPlantContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnBuy = new FontAwesome.Sharp.IconButton();
            this.btnCart = new FontAwesome.Sharp.IconButton();
            this.pControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).BeginInit();
            this.pPlantPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlant)).BeginInit();
            this.pPlantName.SuspendLayout();
            this.pControl2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.pControl.Controls.Add(this.icExit);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl.Location = new System.Drawing.Point(0, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(461, 30);
            this.pControl.TabIndex = 0;
            // 
            // icExit
            // 
            this.icExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExit.BackColor = System.Drawing.Color.Transparent;
            this.icExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.icExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.icExit.IconColor = System.Drawing.Color.Gainsboro;
            this.icExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icExit.IconSize = 30;
            this.icExit.Location = new System.Drawing.Point(429, 0);
            this.icExit.Name = "icExit";
            this.icExit.Size = new System.Drawing.Size(31, 30);
            this.icExit.TabIndex = 3;
            this.icExit.TabStop = false;
            this.icExit.Click += new System.EventHandler(this.icExit_Click);
            this.icExit.MouseLeave += new System.EventHandler(this.icExit_MouseLeave);
            this.icExit.MouseHover += new System.EventHandler(this.icExit_MouseHover);
            // 
            // pPlantPicture
            // 
            this.pPlantPicture.Controls.Add(this.ptbPlant);
            this.pPlantPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlantPicture.Location = new System.Drawing.Point(0, 30);
            this.pPlantPicture.Name = "pPlantPicture";
            this.pPlantPicture.Size = new System.Drawing.Size(461, 209);
            this.pPlantPicture.TabIndex = 1;
            // 
            // ptbPlant
            // 
            this.ptbPlant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbPlant.Location = new System.Drawing.Point(119, 3);
            this.ptbPlant.Name = "ptbPlant";
            this.ptbPlant.Size = new System.Drawing.Size(231, 202);
            this.ptbPlant.TabIndex = 0;
            this.ptbPlant.TabStop = false;
            // 
            // pPlantName
            // 
            this.pPlantName.Controls.Add(this.lbPlantName);
            this.pPlantName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlantName.Location = new System.Drawing.Point(0, 239);
            this.pPlantName.Name = "pPlantName";
            this.pPlantName.Size = new System.Drawing.Size(461, 69);
            this.pPlantName.TabIndex = 2;
            // 
            // lbPlantName
            // 
            this.lbPlantName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPlantName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlantName.Location = new System.Drawing.Point(0, 0);
            this.lbPlantName.Name = "lbPlantName";
            this.lbPlantName.Size = new System.Drawing.Size(461, 42);
            this.lbPlantName.TabIndex = 0;
            this.lbPlantName.Text = "label1";
            this.lbPlantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pControl2
            // 
            this.pControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.pControl2.Controls.Add(this.btnReview);
            this.pControl2.Controls.Add(this.btnDescription);
            this.pControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl2.Location = new System.Drawing.Point(0, 308);
            this.pControl2.Name = "pControl2";
            this.pControl2.Size = new System.Drawing.Size(461, 43);
            this.pControl2.TabIndex = 3;
            // 
            // btnReview
            // 
            this.btnReview.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReview.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.btnReview.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReview.IconSize = 32;
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(242, 0);
            this.btnReview.Name = "btnReview";
            this.btnReview.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReview.Size = new System.Drawing.Size(184, 42);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "Review";
            this.btnReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReview.UseVisualStyleBackColor = false;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnDescription
            // 
            this.btnDescription.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.btnDescription.FlatAppearance.BorderSize = 0;
            this.btnDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDescription.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnDescription.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDescription.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescription.IconSize = 32;
            this.btnDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescription.Location = new System.Drawing.Point(34, 0);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDescription.Size = new System.Drawing.Size(184, 42);
            this.btnDescription.TabIndex = 2;
            this.btnDescription.Text = "Description";
            this.btnDescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescription.UseVisualStyleBackColor = false;
            this.btnDescription.Click += new System.EventHandler(this.btnDescription_Click);
            // 
            // pPlantContent
            // 
            this.pPlantContent.BackColor = System.Drawing.Color.Transparent;
            this.pPlantContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPlantContent.Location = new System.Drawing.Point(0, 351);
            this.pPlantContent.Name = "pPlantContent";
            this.pPlantContent.Size = new System.Drawing.Size(461, 465);
            this.pPlantContent.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(100)))));
            this.panel1.Controls.Add(this.txbTotalPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nmQuantity);
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 730);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 86);
            this.panel1.TabIndex = 5;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(298, 9);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(115, 30);
            this.txbTotalPrice.TabIndex = 10;
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(239, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Price:";
            // 
            // nmQuantity
            // 
            this.nmQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nmQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmQuantity.Location = new System.Drawing.Point(136, 10);
            this.nmQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(62, 30);
            this.nmQuantity.TabIndex = 8;
            this.nmQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQuantity.ValueChanged += new System.EventHandler(this.nmQuantity_ValueChanged);
            // 
            // lbQuantity
            // 
            this.lbQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbQuantity.Location = new System.Drawing.Point(48, 11);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(91, 25);
            this.lbQuantity.TabIndex = 7;
            this.lbQuantity.Text = "Quantity:";
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btnBuy.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuy.IconSize = 32;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(242, 44);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuy.Size = new System.Drawing.Size(184, 37);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Buy Now";
            this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnCart
            // 
            this.btnCart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCart.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnCart.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCart.IconSize = 32;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(34, 44);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCart.Size = new System.Drawing.Size(182, 37);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Add to Cart";
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // fPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(461, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pPlantContent);
            this.Controls.Add(this.pControl2);
            this.Controls.Add(this.pPlantName);
            this.Controls.Add(this.pPlantPicture);
            this.Controls.Add(this.pControl);
            this.Name = "fPlant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plant";
            this.pControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).EndInit();
            this.pPlantPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlant)).EndInit();
            this.pPlantName.ResumeLayout(false);
            this.pControl2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControl;
        private System.Windows.Forms.Panel pPlantPicture;
        private FontAwesome.Sharp.IconPictureBox icExit;
        private System.Windows.Forms.Panel pPlantName;
        private System.Windows.Forms.Panel pControl2;
        private System.Windows.Forms.PictureBox ptbPlant;
        private System.Windows.Forms.Label lbPlantName;
        private FontAwesome.Sharp.IconButton btnReview;
        private FontAwesome.Sharp.IconButton btnDescription;
        private System.Windows.Forms.Panel pPlantContent;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuy;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private FontAwesome.Sharp.IconButton btnCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTotalPrice;
    }
}