using FontAwesome.Sharp;
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
    internal class CartItem: Panel
    {
        private DataRow plant;
        private int quantity;
        private int w = 800;
        private int h = 100;
        private bool chosed = false;
        PictureBox ptb = new PictureBox();
        Label lbItemName = new Label();
        Label lbItemQuantity = new Label();
        Label lbItemPrice = new Label();
        IconPictureBox icpbCheck = new IconPictureBox();
        IconPictureBox icpbRemove = new IconPictureBox();

        public CartItem(string id, int q)
        {
            MyData data = new MyData();
            plant = data.Plants.Select("id='" + id + "'")[0];
            quantity = q;

            this.Size = new Size(w, h);
            this.BackColor = Color.White;
            this.Margin = new Padding(10, 10, 10, 10);

            ptb.Size = new Size(90, 90);
            ptb.Location = new Point(5, 5);
            ResourceManager Plant = new ResourceManager("Shopping_App.Plants", Assembly.GetExecutingAssembly());
            ptb.BackgroundImage = (Image)Plant.GetObject(string.Join("_", plant["name"].ToString().Split(' ')));
            ptb.BackgroundImageLayout = ImageLayout.Stretch;

            lbItemName.Text = plant["name"].ToString();
            lbItemName.TextAlign = ContentAlignment.MiddleCenter;
            lbItemName.Location = new Point(110, 10);
            lbItemName.Font = new Font("Arial", 15, FontStyle.Bold);
            lbItemName.AutoSize = true;
            lbItemName.ForeColor = Color.LightGray;

            lbItemQuantity.Text = "Quantity: " + quantity.ToString();
            lbItemQuantity.TextAlign = ContentAlignment.MiddleCenter;
            lbItemQuantity.Location = new Point(110, 42);
            lbItemQuantity.Font = new Font("Arial", 11, FontStyle.Bold);
            lbItemQuantity.AutoSize = true;
            lbItemQuantity.ForeColor = Color.LightGray;

            lbItemPrice.Text = "Cost: $" + (float.Parse(plant["price"].ToString()) * quantity).ToString();
            lbItemPrice.TextAlign = ContentAlignment.MiddleCenter;
            lbItemPrice.Location = new Point(110, 68);
            lbItemPrice.Font = new Font("Arial", 11, FontStyle.Bold);
            lbItemPrice.AutoSize = true;
            lbItemPrice.ForeColor = Color.LightGray;

            icpbCheck.Size = new Size(50, 50);
            icpbCheck.Location = new Point(680, 30);
            icpbCheck.IconChar = IconChar.Square;
            icpbCheck.ForeColor = Color.FromArgb(0, 177, 64);
            icpbCheck.Click += Check_Click;

            icpbRemove.Size = new Size(50, 50);
            icpbRemove.Location = new Point(740, 30);
            icpbRemove.IconChar = IconChar.SquareXmark;
            icpbRemove.ForeColor = Color.FromArgb(194, 24, 7);
            icpbRemove.Click += Remove_Click;

            this.Controls.Add(ptb);
            this.Controls.Add(lbItemName);
            this.Controls.Add(lbItemQuantity);
            this.Controls.Add(lbItemPrice);
            this.Controls.Add(icpbCheck);
            this.Controls.Add(icpbRemove);
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (chosed)
            {
                icpbCheck.IconChar = IconChar.Square;
                chosed = false;
            }
            else
            {
                icpbCheck.IconChar = IconChar.SquareCheck;
                chosed = true;
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
