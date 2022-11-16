using FontAwesome.Sharp;
using Shopping_App.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
        public DataRow plant;
        private int quantity;
        private int w = 800;
        private int h = 100;
        private bool chosed = false;
        public PictureBox ptb = new PictureBox();
        public Label lbItemName = new Label();
        public Label lbItemQuantity = new Label();
        public Label lbItemPrice = new Label();
        public Label lbItemDate = new Label();
        public IconPictureBox icpbCheck = new IconPictureBox();
        public IconPictureBox icpbRemove = new IconPictureBox();

        public CartItem(string id, int q, string date)
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

            lbItemDate.Text = date;
            lbItemDate.TextAlign = ContentAlignment.MiddleRight;
            lbItemDate.Location = new Point(640, 5);
            lbItemDate.Font = new Font("Arial", 10, FontStyle.Regular);
            lbItemDate.AutoSize = true;
            lbItemDate.ForeColor = Color.LightGray;

            icpbCheck.Size = new Size(50, 50);
            icpbCheck.Location = new Point(680, 30);
            icpbCheck.IconChar = IconChar.Square;
            icpbCheck.ForeColor = Color.FromArgb(0, 177, 64);
            icpbCheck.Click += Check_Click;

            icpbRemove.Size = new Size(50, 50);
            icpbRemove.Location = new Point(740, 30);
            icpbRemove.IconChar = IconChar.SquareXmark;
            icpbRemove.ForeColor = Color.FromArgb(194, 24, 7);

            this.Controls.Add(ptb);
            this.Controls.Add(lbItemName);
            this.Controls.Add(lbItemQuantity);
            this.Controls.Add(lbItemPrice);
            this.Controls.Add(lbItemDate);
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
            string filePath = @"cart.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            List<string> new_lines = new List<string>();
            foreach (string line in lines)
            {
                string[] infor = line.Split(',');
                if (infor[0] == plant["id"].ToString())
                {
                    continue;
                }
                new_lines.Add(line);
            }
            File.WriteAllLines(filePath, new_lines.ToArray());
        }
    }
}
