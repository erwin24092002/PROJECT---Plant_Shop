using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fPlant : Form
    {
        private DataRow plant;
        public fPlant(string id)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            MyData data = new MyData();
            plant = data.Plants.Select("id=" + id)[0];

            ResourceManager PlantManager = new ResourceManager("Shopping_App.Plants", Assembly.GetExecutingAssembly());
            this.ptbPlant.BackgroundImage = (Image)PlantManager.GetObject(string.Join("_", plant["name"].ToString().Split(' ')));
            this.ptbPlant.BackgroundImageLayout = ImageLayout.Stretch;

            this.lbPlantName.Text = plant["name"].ToString();
            this.txbTotalPrice.Text = "$" + (float.Parse(plant["price"].ToString()) * (float)this.nmQuantity.Value).ToString();
            Show_Description();
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            this.txbTotalPrice.Text = "$" + (float.Parse(plant["price"].ToString()) * (float)this.nmQuantity.Value).ToString();
        }

        private void icExit_MouseHover(object sender, EventArgs e)
        {
            ((IconPictureBox)sender).ForeColor = Color.Red;
        }

        private void icExit_MouseLeave(object sender, EventArgs e)
        {
            ((IconPictureBox)sender).ForeColor = Color.Gainsboro;
        }

        private void Show_Description()
        {
            RichTextBox rtbDescription = new RichTextBox();
            int w = pPlantContent.Width - pPlantContent.Width / 10;
            int h = pPlantContent.Height - pPlantContent.Height / 10;
            int x = pPlantContent.Width / 20;
            int y = 10;
            rtbDescription.Size = new Size(w, h);
            rtbDescription.Location = new Point(x, y);
            rtbDescription.BorderStyle = BorderStyle.None;
            /*rtbDescription.BackColor = Color.Transparent;*/
            rtbDescription.Font = new Font("Arial", 15, FontStyle.Regular);
            rtbDescription.ForeColor = Color.Gainsboro;
            rtbDescription.Text = "Common Name: " + plant["common name"].ToString() + "\n" + plant["descript"].ToString();
            this.pPlantContent.Controls.Add(rtbDescription);
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            Show_Description();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            this.pPlantContent.Controls.Clear();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            string filePath = @"cart.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            string date = DateTime.Now.ToString("MMMM dd, yyyy");
            lines.Add(plant["id"].ToString() + "," + this.nmQuantity.Value.ToString() + "," + date);
            File.WriteAllLines(filePath, lines.ToArray());
            MessageBox.Show("Add \"" + plant["name"] + "\" to cart successfully");
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<string> lines = new List<string>();
            lines.Add(plant["id"].ToString() + "," + this.nmQuantity.Value.ToString() + "," + DateTime.Now.ToString("MMMM dd, yyyy"));
            fCheckOut f = new fCheckOut(lines);
            f.ShowDialog();
            this.Close();
        }
    }
}
