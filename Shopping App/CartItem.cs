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
        public CartItem(string id, int q)
        {
            MyData data = new MyData();
            plant = data.Plants.Select("id='" + id + "'")[0];
            quantity = q;

            this.Size = new Size(w, h);
            this.BackColor = Color.White;
            this.Margin = new Padding(10, 10, 10, 10);

            PictureBox ptb = new PictureBox();
            ptb.Size = new Size(90, 90);
            ptb.Location = new Point(5, 5);
            ResourceManager Plant = new ResourceManager("Shopping_App.Plants", Assembly.GetExecutingAssembly());
            ptb.BackgroundImage = (Image)Plant.GetObject(string.Join("_", plant["name"].ToString().Split(' ')));
            ptb.BackgroundImageLayout = ImageLayout.Stretch;

            Label lbItemName = new Label();
            lbItemName.Text = plant["name"].ToString();
            lbItemName.TextAlign = ContentAlignment.MiddleCenter;
            lbItemName.Location = new Point(110, 10);
            lbItemName.Font = new Font("Arial", 15, FontStyle.Bold);
            lbItemName.AutoSize = true;
            lbItemName.ForeColor = Color.LightGray;

            Label lbItemQuantity = new Label();
            lbItemQuantity.Text = "Quantity: " + quantity.ToString();
            lbItemQuantity.TextAlign = ContentAlignment.MiddleCenter;
            lbItemQuantity.Location = new Point(110, 42);
            lbItemQuantity.Font = new Font("Arial", 11, FontStyle.Bold);
            lbItemQuantity.AutoSize = true;
            lbItemQuantity.ForeColor = Color.LightGray;

            Label lbItemPrice = new Label();
            lbItemPrice.Text = "Cost: $" + (float.Parse(plant["price"].ToString()) * quantity).ToString();
            lbItemPrice.TextAlign = ContentAlignment.MiddleCenter;
            lbItemPrice.Location = new Point(110, 68);
            lbItemPrice.Font = new Font("Arial", 11, FontStyle.Bold);
            lbItemPrice.AutoSize = true;
            lbItemPrice.ForeColor = Color.LightGray;

            this.Controls.Add(ptb);
            this.Controls.Add(lbItemName);
            this.Controls.Add(lbItemQuantity);
            this.Controls.Add(lbItemPrice);
        }
    }
}
