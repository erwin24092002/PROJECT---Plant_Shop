namespace Shopping_App.Forms
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
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pPlantInfor = new System.Windows.Forms.Panel();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSmall = new System.Windows.Forms.CheckBox();
            this.cbMedium = new System.Windows.Forms.CheckBox();
            this.cbLarge = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.gbQuality = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.pSelectBar.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbQuality.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSelectBar
            // 
            this.pSelectBar.Controls.Add(this.gbQuality);
            this.pSelectBar.Controls.Add(this.groupBox1);
            this.pSelectBar.Controls.Add(this.gbSize);
            this.pSelectBar.Controls.Add(this.btnSearch);
            this.pSelectBar.Controls.Add(this.tbSearch);
            this.pSelectBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSelectBar.Location = new System.Drawing.Point(0, 0);
            this.pSelectBar.Name = "pSelectBar";
            this.pSelectBar.Size = new System.Drawing.Size(1107, 108);
            this.pSelectBar.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.btnSearch.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 32;
            this.btnSearch.Location = new System.Drawing.Point(735, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSearch.Size = new System.Drawing.Size(36, 33);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(314, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(415, 41);
            this.tbSearch.TabIndex = 0;
            // 
            // flpItems
            // 
            this.flpItems.AutoScroll = true;
            this.flpItems.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.flpItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpItems.Location = new System.Drawing.Point(0, 108);
            this.flpItems.Name = "flpItems";
            this.flpItems.Size = new System.Drawing.Size(1107, 560);
            this.flpItems.TabIndex = 1;
            // 
            // pPlantInfor
            // 
            this.pPlantInfor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pPlantInfor.Location = new System.Drawing.Point(1106, 108);
            this.pPlantInfor.Name = "pPlantInfor";
            this.pPlantInfor.Size = new System.Drawing.Size(1, 560);
            this.pPlantInfor.TabIndex = 2;
            // 
            // gbSize
            // 
            this.gbSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSize.Controls.Add(this.cbLarge);
            this.gbSize.Controls.Add(this.cbMedium);
            this.gbSize.Controls.Add(this.cbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(165, 50);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(276, 52);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(468, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // cbSmall
            // 
            this.cbSmall.AutoSize = true;
            this.cbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSmall.Location = new System.Drawing.Point(6, 24);
            this.cbSmall.Name = "cbSmall";
            this.cbSmall.Size = new System.Drawing.Size(67, 22);
            this.cbSmall.TabIndex = 0;
            this.cbSmall.Text = "Small";
            this.cbSmall.UseVisualStyleBackColor = true;
            // 
            // cbMedium
            // 
            this.cbMedium.AutoSize = true;
            this.cbMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMedium.Location = new System.Drawing.Point(93, 24);
            this.cbMedium.Name = "cbMedium";
            this.cbMedium.Size = new System.Drawing.Size(83, 22);
            this.cbMedium.TabIndex = 1;
            this.cbMedium.Text = "Medium";
            this.cbMedium.UseVisualStyleBackColor = true;
            // 
            // cbLarge
            // 
            this.cbLarge.AutoSize = true;
            this.cbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLarge.Location = new System.Drawing.Point(193, 24);
            this.cbLarge.Name = "cbLarge";
            this.cbLarge.Size = new System.Drawing.Size(67, 22);
            this.cbLarge.TabIndex = 2;
            this.cbLarge.Text = "Large";
            this.cbLarge.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 22);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Cheap";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(103, 24);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(97, 22);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Expensive";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // gbQuality
            // 
            this.gbQuality.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbQuality.Controls.Add(this.checkBox5);
            this.gbQuality.Controls.Add(this.checkBox3);
            this.gbQuality.Controls.Add(this.checkBox4);
            this.gbQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuality.Location = new System.Drawing.Point(711, 50);
            this.gbQuality.Name = "gbQuality";
            this.gbQuality.Size = new System.Drawing.Size(285, 52);
            this.gbQuality.TabIndex = 5;
            this.gbQuality.TabStop = false;
            this.gbQuality.Text = "Quality";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(93, 24);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(83, 22);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.Text = "Medium";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(6, 24);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(58, 22);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Low";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(204, 24);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(60, 22);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "High";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // fShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 668);
            this.Controls.Add(this.pPlantInfor);
            this.Controls.Add(this.flpItems);
            this.Controls.Add(this.pSelectBar);
            this.Name = "fShop";
            this.Text = "Shop";
            this.pSelectBar.ResumeLayout(false);
            this.pSelectBar.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbQuality.ResumeLayout(false);
            this.gbQuality.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSelectBar;
        private System.Windows.Forms.FlowLayoutPanel flpItems;
        private System.Windows.Forms.Panel pPlantInfor;
        private System.Windows.Forms.TextBox tbSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLarge;
        private System.Windows.Forms.CheckBox cbMedium;
        private System.Windows.Forms.CheckBox cbSmall;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gbQuality;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}