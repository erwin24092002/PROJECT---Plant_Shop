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
            this.gbQuality = new System.Windows.Forms.GroupBox();
            this.cbHigh = new System.Windows.Forms.CheckBox();
            this.cbMediumQuality = new System.Windows.Forms.CheckBox();
            this.cbLow = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbExpensive = new System.Windows.Forms.CheckBox();
            this.cbCheap = new System.Windows.Forms.CheckBox();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.cbLarge = new System.Windows.Forms.CheckBox();
            this.cbMediumSize = new System.Windows.Forms.CheckBox();
            this.cbSmall = new System.Windows.Forms.CheckBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.flpItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pPlantInfor = new System.Windows.Forms.Panel();
            this.pSelectBar.SuspendLayout();
            this.gbQuality.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSize.SuspendLayout();
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
            // gbQuality
            // 
            this.gbQuality.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbQuality.Controls.Add(this.cbHigh);
            this.gbQuality.Controls.Add(this.cbMediumQuality);
            this.gbQuality.Controls.Add(this.cbLow);
            this.gbQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuality.Location = new System.Drawing.Point(711, 50);
            this.gbQuality.Name = "gbQuality";
            this.gbQuality.Size = new System.Drawing.Size(285, 52);
            this.gbQuality.TabIndex = 5;
            this.gbQuality.TabStop = false;
            this.gbQuality.Text = "Quality";
            // 
            // cbHigh
            // 
            this.cbHigh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHigh.AutoSize = true;
            this.cbHigh.Checked = true;
            this.cbHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHigh.Location = new System.Drawing.Point(204, 24);
            this.cbHigh.Name = "cbHigh";
            this.cbHigh.Size = new System.Drawing.Size(60, 22);
            this.cbHigh.TabIndex = 5;
            this.cbHigh.Text = "High";
            this.cbHigh.UseVisualStyleBackColor = true;
            this.cbHigh.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // cbMediumQuality
            // 
            this.cbMediumQuality.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMediumQuality.AutoSize = true;
            this.cbMediumQuality.Checked = true;
            this.cbMediumQuality.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMediumQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMediumQuality.Location = new System.Drawing.Point(93, 24);
            this.cbMediumQuality.Name = "cbMediumQuality";
            this.cbMediumQuality.Size = new System.Drawing.Size(83, 22);
            this.cbMediumQuality.TabIndex = 4;
            this.cbMediumQuality.Text = "Medium";
            this.cbMediumQuality.UseVisualStyleBackColor = true;
            this.cbMediumQuality.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // cbLow
            // 
            this.cbLow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLow.AutoSize = true;
            this.cbLow.Checked = true;
            this.cbLow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLow.Location = new System.Drawing.Point(6, 24);
            this.cbLow.Name = "cbLow";
            this.cbLow.Size = new System.Drawing.Size(58, 22);
            this.cbLow.TabIndex = 3;
            this.cbLow.Text = "Low";
            this.cbLow.UseVisualStyleBackColor = true;
            this.cbLow.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.cbExpensive);
            this.groupBox1.Controls.Add(this.cbCheap);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(468, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Price";
            // 
            // cbExpensive
            // 
            this.cbExpensive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbExpensive.AutoSize = true;
            this.cbExpensive.Checked = true;
            this.cbExpensive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbExpensive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExpensive.Location = new System.Drawing.Point(103, 24);
            this.cbExpensive.Name = "cbExpensive";
            this.cbExpensive.Size = new System.Drawing.Size(97, 22);
            this.cbExpensive.TabIndex = 4;
            this.cbExpensive.Text = "Expensive";
            this.cbExpensive.UseVisualStyleBackColor = true;
            this.cbExpensive.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // cbCheap
            // 
            this.cbCheap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbCheap.AutoSize = true;
            this.cbCheap.Checked = true;
            this.cbCheap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCheap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCheap.Location = new System.Drawing.Point(6, 24);
            this.cbCheap.Name = "cbCheap";
            this.cbCheap.Size = new System.Drawing.Size(73, 22);
            this.cbCheap.TabIndex = 3;
            this.cbCheap.Text = "Cheap";
            this.cbCheap.UseVisualStyleBackColor = true;
            this.cbCheap.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // gbSize
            // 
            this.gbSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSize.Controls.Add(this.cbLarge);
            this.gbSize.Controls.Add(this.cbMediumSize);
            this.gbSize.Controls.Add(this.cbSmall);
            this.gbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.Location = new System.Drawing.Point(165, 50);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(276, 52);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // cbLarge
            // 
            this.cbLarge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbLarge.AutoSize = true;
            this.cbLarge.Checked = true;
            this.cbLarge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLarge.Location = new System.Drawing.Point(193, 24);
            this.cbLarge.Name = "cbLarge";
            this.cbLarge.Size = new System.Drawing.Size(67, 22);
            this.cbLarge.TabIndex = 2;
            this.cbLarge.Text = "Large";
            this.cbLarge.UseVisualStyleBackColor = true;
            this.cbLarge.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // cbMediumSize
            // 
            this.cbMediumSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMediumSize.AutoSize = true;
            this.cbMediumSize.Checked = true;
            this.cbMediumSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMediumSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMediumSize.Location = new System.Drawing.Point(93, 24);
            this.cbMediumSize.Name = "cbMediumSize";
            this.cbMediumSize.Size = new System.Drawing.Size(83, 22);
            this.cbMediumSize.TabIndex = 1;
            this.cbMediumSize.Text = "Medium";
            this.cbMediumSize.UseVisualStyleBackColor = true;
            this.cbMediumSize.Click += new System.EventHandler(this.Checkbox_Click);
            // 
            // cbSmall
            // 
            this.cbSmall.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSmall.AutoSize = true;
            this.cbSmall.Checked = true;
            this.cbSmall.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSmall.Location = new System.Drawing.Point(6, 24);
            this.cbSmall.Name = "cbSmall";
            this.cbSmall.Size = new System.Drawing.Size(67, 22);
            this.cbSmall.TabIndex = 0;
            this.cbSmall.Text = "Small";
            this.cbSmall.UseVisualStyleBackColor = true;
            this.cbSmall.Click += new System.EventHandler(this.Checkbox_Click);
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
            this.gbQuality.ResumeLayout(false);
            this.gbQuality.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbMediumSize;
        private System.Windows.Forms.CheckBox cbSmall;
        private System.Windows.Forms.CheckBox cbExpensive;
        private System.Windows.Forms.CheckBox cbCheap;
        private System.Windows.Forms.GroupBox gbQuality;
        private System.Windows.Forms.CheckBox cbMediumQuality;
        private System.Windows.Forms.CheckBox cbLow;
        private System.Windows.Forms.CheckBox cbHigh;
    }
}