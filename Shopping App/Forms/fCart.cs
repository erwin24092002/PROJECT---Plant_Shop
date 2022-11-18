using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fCart : Form
    {
        public fCart()
        {
            InitializeComponent();
            CartRender();
        }

        public void CartRender()
        {
            flpCart.Controls.Clear();
            string filePath = @"cart.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] infor = line.Split(',');
                CartItem item = new CartItem(infor[0], Int32.Parse(infor[1]), infor[2] + "," + infor[3]);
                item.icpbRemove.Click += Remove_Click;
                item.icpbRemove.Tag = line;
                this.flpCart.Controls.Add(item);
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
                if (line == ((IconPictureBox)sender).Tag.ToString())
                    continue;
                new_lines.Add(line);
            }
            File.WriteAllLines(filePath, new_lines.ToArray());
            MessageBox.Show("Removed \"products\" from cart successfully!");
            CartRender();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            foreach (CartItem item in this.flpCart.Controls)
            {
                if (item.icpbCheck.IconChar == IconChar.SquareCheck)
                {
                    lines.Add(item.icpbRemove.Tag.ToString());
                }
            }
            if (lines.Count > 0)
            {
                fCheckOut f = new fCheckOut(lines);
                f.ShowDialog();
                CartRender();
            }
            else
            {
                MessageBox.Show("You need to select the product before payment!");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            flpCart.Controls.Clear();
            string filePath = @"cart.txt";
            MyData data = new MyData();
            DataRow[] plants = data.Plants.Select("name like '%" + txbSearch.Text + "%'");
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] infor = line.Split(',');
                int flag = 0;
                foreach (DataRow plant in plants)
                    if (infor[0] == plant["id"].ToString())
                        flag = 1;
                if (flag == 0)
                    continue;
                CartItem item = new CartItem(infor[0], Int32.Parse(infor[1]), infor[2] + "," + infor[3]);
                item.icpbRemove.Click += Remove_Click;
                item.icpbRemove.Tag = line;
                this.flpCart.Controls.Add(item);
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            flpCart.Controls.Clear();
            string filePath = @"cart.txt";
            MyData data = new MyData();
            DataRow[] plants = data.Plants.Select("name like '%" + txbSearch.Text + "%'");
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] infor = line.Split(',');
                int flag = 0;
                foreach(DataRow plant in plants)
                    if (infor[0] == plant["id"].ToString())
                        flag = 1;
                if (flag == 0)
                    continue;
                CartItem item = new CartItem(infor[0], Int32.Parse(infor[1]), infor[2] + "," + infor[3]);
                item.icpbRemove.Click += Remove_Click;
                item.icpbRemove.Tag = line;
                this.flpCart.Controls.Add(item);
            }
        }
    }
}
