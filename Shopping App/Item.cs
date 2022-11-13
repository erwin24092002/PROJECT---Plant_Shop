using System;
using System.Collections.Generic;
using System.Data;
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
        public Item(DataRow plant)
        {
            this.Size = new Size(size, size + (size / 4));
            this.BackColor = Color.White;
            this.Margin = new Padding(size/20, size/20, size/20, size/20);

            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(size, size);
            /*Bitmap bm1 = (Bitmap)NHACCU.ResourceManager.GetObject(id);*/
            /*ptb.BackgroundImage = bm1;*/
            ptb.BackgroundImageLayout = ImageLayout.Stretch;

            Panel pItemInfo = new Panel();
            pItemInfo.Size = new Size(size, size / 4);
            pItemInfo.Location = new Point(0, size);
            pItemInfo.BackColor = Color.DimGray;

            Button btnInfo = new Button();
            btnInfo.Text = "More";
            btnInfo.Size = new Size(size / 4, size / 8);
            btnInfo.Location = new Point(size / 2 + size / 4 - size / 16, size / 8 - size / 16);
            btnInfo.BackColor = Color.LightGray;
            pItemInfo.Controls.Add(btnInfo);

            Label lbItemName = new Label();
            lbItemName.Text = plant["name"].ToString();
            lbItemName.Location = new Point(0, 8);
            lbItemName.Font = new Font("Arial", 10, FontStyle.Bold);
            lbItemName.Size = new Size(size / 2 + size / 16, size / 8 - size / 16);
            lbItemName.ForeColor = Color.LightGray;
            pItemInfo.Controls.Add(lbItemName);

            Label lbItemPrice = new Label();
            lbItemPrice.Text = "$" + plant["price"].ToString();
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
