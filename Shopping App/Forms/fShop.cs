using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fShop : Form
    {
        public fShop()
        {
            InitializeComponent();
            Render();
        }

        private void Render()
        {
            MyData data = new MyData();
            DataRowCollection plants = data.Plants.Rows;
            for (int id = 0; id < plants.Count; id++)
            {
                if (!cbSmall.Checked && plants[id]["size"].ToString() == "s")
                    continue;
                if (!cbMediumSize.Checked && plants[id]["size"].ToString() == "m")
                    continue;
                if (!cbLarge.Checked && plants[id]["size"].ToString() == "l")
                    continue;
                if (!cbCheap.Checked && float.Parse(plants[id]["price"].ToString()) < 20)
                    continue;
                if (!cbExpensive.Checked && float.Parse(plants[id]["price"].ToString()) >= 20)
                    continue;
                Item item = new Item(plants[id]);
                flpItems.Controls.Add(item);
            }
        }

        private void Checkbox_Click(object sender, EventArgs e)
        {
            flpItems.Controls.Clear();
            Render();
        }
    }
}
