using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private float price;
        public fPlant(string id)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            MyData data = new MyData();
            DataRow plant = data.Plants.Select("id=" + id)[0];

            ResourceManager PlantManager = new ResourceManager("Shopping_App.Plants", Assembly.GetExecutingAssembly());
            this.ptbPlant.BackgroundImage = (Image)PlantManager.GetObject(string.Join("_", plant["name"].ToString().Split(' ')));
            this.ptbPlant.BackgroundImageLayout = ImageLayout.Stretch;

            this.lbPlantName.Text = plant["name"].ToString();
            price = float.Parse(plant["price"].ToString());
            this.txbTotalPrice.Text = "$" + ( price * (float)this.nmQuantity.Value).ToString();
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            this.txbTotalPrice.Text = "$" + (price * (float)this.nmQuantity.Value).ToString();
        }

        private void icExit_MouseHover(object sender, EventArgs e)
        {
            ((IconPictureBox)sender).ForeColor = Color.Red;
        }

        private void icExit_MouseLeave(object sender, EventArgs e)
        {
            ((IconPictureBox)sender).ForeColor = Color.Gainsboro;
        }
    }
}
