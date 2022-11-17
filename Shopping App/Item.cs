using Shopping_App.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App
{
    internal class Item : Panel
    {
        public Item(DataRow plant)
        {
            this.Size = new Size(250, 340);
            this.BackColor = Color.White;
            this.Margin = new Padding(13, 13, 13, 13);

            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(250, 250);
            ResourceManager Plant = new ResourceManager("Shopping_App.Plants", Assembly.GetExecutingAssembly());
            ptb.BackgroundImage = (Image)Plant.GetObject(string.Join("_", plant["name"].ToString().Split(' ')));
            ptb.BackgroundImageLayout = ImageLayout.Stretch;

            Panel pItemInfo = new Panel();
            pItemInfo.Size = new Size(250, 90);
            pItemInfo.Location = new Point(0, 250);
            pItemInfo.BackColor = Color.DimGray;

            Label lbItemName = new Label();
            lbItemName.Text = plant["name"].ToString();
            lbItemName.TextAlign = ContentAlignment.MiddleCenter;
            lbItemName.Location = new Point(0, 8);
            lbItemName.Font = new Font("Arial", 10, FontStyle.Bold);
            lbItemName.Size = new Size(250, 20);
            lbItemName.ForeColor = Color.LightGray;
            pItemInfo.Controls.Add(lbItemName);

            Label lbItemPrice = new Label();
            lbItemPrice.Text = "$" + plant["price"].ToString();
            lbItemPrice.TextAlign = ContentAlignment.MiddleLeft;
            lbItemPrice.Location = new Point(20, 60);
            lbItemPrice.Font = new Font("Arial", 11, FontStyle.Bold);
            lbItemPrice.Size = new Size(70, 20);
            lbItemPrice.ForeColor = Color.White;
            pItemInfo.Controls.Add(lbItemPrice);

            Button btnInfo = new Button();
            btnInfo.Text = "Buy";
            btnInfo.Font = new Font("Arial", 11, FontStyle.Bold);
            btnInfo.TextAlign = ContentAlignment.MiddleCenter;
            btnInfo.Location = new Point(158, 53);
            btnInfo.Size = new Size(70, 30);
            btnInfo.BackColor = Color.LightGray;
            btnInfo.Tag = plant["id"];
            btnInfo.Click += btnBuy_Click;
            pItemInfo.Controls.Add(btnInfo);

            this.Controls.Add(pItemInfo);
            this.Controls.Add(ptb);
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            fPlant childForm = new fPlant(((Button)sender).Tag.ToString());
            childForm.ShowDialog();
        }
    }
}
