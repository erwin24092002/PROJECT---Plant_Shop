﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App
{
    internal class Item : Panel
    {
        int size = 256;
        public Item(string id)
        {
            this.Size = new Size(size, size + (size / 4));
            this.BackColor = Color.White;

            /*Bitmap bm1 = (Bitmap)NHACCU.ResourceManager.GetObject(id);*/

            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(size, size);
            /*ptb.BackgroundImage = bm1;*/
            ptb.BackgroundImageLayout = ImageLayout.Stretch;

            Panel pItemInfo = new Panel();
            pItemInfo.Size = new Size(size, size / 4);
            pItemInfo.Location = new Point(0, size);
            pItemInfo.BackColor = Color.DimGray;

            Button btnInfo = new Button();
            btnInfo.Text = "Xem thêm";
            btnInfo.Size = new Size(size / 4, size / 8);
            btnInfo.Location = new Point(size / 2 + size / 4 - size / 16, size / 8 - size / 16);
            btnInfo.BackColor = Color.LightGray;
            pItemInfo.Controls.Add(btnInfo);

            Label lbItemName = new Label();
            /*name.Text = nameOfItem;*/
            lbItemName.Location = new Point(0, 8);
            lbItemName.Font = new Font("Arial", 10, FontStyle.Bold);
            lbItemName.Size = new Size(size / 2 + size / 16, size / 8 - size / 16);
            lbItemName.ForeColor = Color.LightGray;
            pItemInfo.Controls.Add(lbItemName);

            Label lbItemPrice = new Label();
            /*lbItemPrice.Text = priceOfItem.ToString("N0") + " VND";*/
            lbItemPrice.Location = new Point(0, size / 8);
            lbItemPrice.Font = new Font("Arial", 12, FontStyle.Bold);
            lbItemPrice.Size = new Size(size / 2 + size / 16, size / 8);
            lbItemPrice.ForeColor = Color.White;
            pItemInfo.Controls.Add(lbItemPrice);

            this.Controls.Add(pItemInfo);
            this.Controls.Add(ptb);
        }
    }
}
