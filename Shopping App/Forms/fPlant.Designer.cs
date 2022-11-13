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
            this.pPlantPicture = new System.Windows.Forms.Panel();
            this.icExit = new FontAwesome.Sharp.IconPictureBox();
            this.pPlantName = new System.Windows.Forms.Panel();
            this.pControl2 = new System.Windows.Forms.Panel();
            this.ptbPlant = new System.Windows.Forms.PictureBox();
            this.lbPlantName = new System.Windows.Forms.Label();
            this.btnDescription = new FontAwesome.Sharp.IconButton();
            this.btnReview = new FontAwesome.Sharp.IconButton();
            this.pPlantContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCart = new FontAwesome.Sharp.IconButton();
            this.btnBuy = new FontAwesome.Sharp.IconButton();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pControl.SuspendLayout();
            this.pPlantPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).BeginInit();
            this.pPlantName.SuspendLayout();
            this.pControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlant)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pControl
            // 
            this.pControl.Controls.Add(this.icExit);
            this.pControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl.Location = new System.Drawing.Point(0, 0);
            this.pControl.Name = "pControl";
            this.pControl.Size = new System.Drawing.Size(424, 30);
            this.pControl.TabIndex = 0;
            // 
            // pPlantPicture
            // 
            this.pPlantPicture.Controls.Add(this.ptbPlant);
            this.pPlantPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlantPicture.Location = new System.Drawing.Point(0, 30);
            this.pPlantPicture.Name = "pPlantPicture";
            this.pPlantPicture.Size = new System.Drawing.Size(424, 209);
            this.pPlantPicture.TabIndex = 1;
            // 
            // icExit
            // 
            this.icExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icExit.BackColor = System.Drawing.Color.Transparent;
            this.icExit.ForeColor = System.Drawing.Color.Green;
            this.icExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.icExit.IconColor = System.Drawing.Color.Green;
            this.icExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icExit.IconSize = 30;
            this.icExit.Location = new System.Drawing.Point(392, 0);
            this.icExit.Name = "icExit";
            this.icExit.Size = new System.Drawing.Size(32, 30);
            this.icExit.TabIndex = 3;
            this.icExit.TabStop = false;
            // 
            // pPlantName
            // 
            this.pPlantName.Controls.Add(this.lbPlantName);
            this.pPlantName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlantName.Location = new System.Drawing.Point(0, 239);
            this.pPlantName.Name = "pPlantName";
            this.pPlantName.Size = new System.Drawing.Size(424, 41);
            this.pPlantName.TabIndex = 2;
            // 
            // pControl2
            // 
            this.pControl2.Controls.Add(this.btnReview);
            this.pControl2.Controls.Add(this.btnDescription);
            this.pControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControl2.Location = new System.Drawing.Point(0, 280);
            this.pControl2.Name = "pControl2";
            this.pControl2.Size = new System.Drawing.Size(424, 57);
            this.pControl2.TabIndex = 3;
            // 
            // ptbPlant
            // 
            this.ptbPlant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ptbPlant.Location = new System.Drawing.Point(101, 3);
            this.ptbPlant.Name = "ptbPlant";
            this.ptbPlant.Size = new System.Drawing.Size(231, 202);
            this.ptbPlant.TabIndex = 0;
            this.ptbPlant.TabStop = false;
            // 
            // lbPlantName
            // 
            this.lbPlantName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlantName.Location = new System.Drawing.Point(12, 3);
            this.lbPlantName.Name = "lbPlantName";
            this.lbPlantName.Size = new System.Drawing.Size(400, 35);
            this.lbPlantName.TabIndex = 0;
            this.lbPlantName.Text = "label1";
            this.lbPlantName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDescription
            // 
            this.btnDescription.FlatAppearance.BorderSize = 0;
            this.btnDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDescription.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnDescription.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDescription.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescription.IconSize = 32;
            this.btnDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescription.Location = new System.Drawing.Point(12, 6);
            this.btnDescription.Name = "btnDescription";
            this.btnDescription.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDescription.Size = new System.Drawing.Size(178, 46);
            this.btnDescription.TabIndex = 2;
            this.btnDescription.Text = "Description";
            this.btnDescription.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescription.UseVisualStyleBackColor = true;
            // 
            // btnReview
            // 
            this.btnReview.FlatAppearance.BorderSize = 0;
            this.btnReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReview.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReview.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnReview.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReview.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReview.IconSize = 32;
            this.btnReview.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReview.Location = new System.Drawing.Point(219, 6);
            this.btnReview.Name = "btnReview";
            this.btnReview.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReview.Size = new System.Drawing.Size(193, 46);
            this.btnReview.TabIndex = 3;
            this.btnReview.Text = "Review";
            this.btnReview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReview.UseVisualStyleBackColor = true;
            // 
            // pPlantContent
            // 
            this.pPlantContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPlantContent.Location = new System.Drawing.Point(0, 337);
            this.pPlantContent.Name = "pPlantContent";
            this.pPlantContent.Size = new System.Drawing.Size(424, 265);
            this.pPlantContent.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.btnCart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 602);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 59);
            this.panel1.TabIndex = 5;
            // 
            // btnCart
            // 
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCart.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnCart.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCart.IconSize = 32;
            this.btnCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Location = new System.Drawing.Point(187, 6);
            this.btnCart.Name = "btnCart";
            this.btnCart.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCart.Size = new System.Drawing.Size(114, 48);
            this.btnCart.TabIndex = 4;
            this.btnCart.Text = "Cart";
            this.btnCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCart.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBuy.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnBuy.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBuy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuy.IconSize = 32;
            this.btnBuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuy.Location = new System.Drawing.Point(307, 6);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBuy.Size = new System.Drawing.Size(114, 48);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Buy";
            this.btnBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(8, 18);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(82, 22);
            this.lbQuantity.TabIndex = 7;
            this.lbQuantity.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(96, 16);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 28);
            this.numericUpDown1.TabIndex = 8;
            // 
            // fPlant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pPlantContent);
            this.Controls.Add(this.pControl2);
            this.Controls.Add(this.pPlantName);
            this.Controls.Add(this.pPlantPicture);
            this.Controls.Add(this.pControl);
            this.Name = "fPlant";
            this.Text = "Plant";
            this.pControl.ResumeLayout(false);
            this.pPlantPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icExit)).EndInit();
            this.pPlantName.ResumeLayout(false);
            this.pControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPlant)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private FontAwesome.Sharp.IconButton btnCart;
        private FontAwesome.Sharp.IconButton btnBuy;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}