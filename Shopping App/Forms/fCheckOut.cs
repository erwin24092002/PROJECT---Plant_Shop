using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace Shopping_App.Forms
{
    public partial class fCheckOut : Form
    {
        List<string> lines = new List<string>();
        DataTable plants = new MyData().Plants;
        DataTable products = new DataTable();
        public fCheckOut(List<string> l)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            int[] flag = new int[l.Count];
            for (int i=0; i < l.Count; i++)
            {
                if (flag[i] == 1)
                    continue;
                string[] i_infor = l[i].Split(',');
                string id = i_infor[0];
                int quantity = Int32.Parse(i_infor[1]);
                for (int j=i+1; j<l.Count; j++)
                {
                    if (flag[j] == 1)
                        continue;
                    string[] j_infor = l[j].Split(',');
                    if (id == j_infor[0])
                    {
                        quantity += Int32.Parse(j_infor[1]);
                        flag[j] = 1;
                    }
                }
                lines.Add(id + "," + quantity.ToString());
            }
            products.Columns.Add("name");
            products.Columns.Add("price");
            products.Columns.Add("quantity", typeof(int));

            foreach (string line in lines)
            {
                string[] infor = line.Split(',');
                DataRow plant = plants.Select("id='" + infor[0] + "'")[0];
                products.Rows.Add(plant["name"].ToString(), plant["price"].ToString(), Int32.Parse(infor[1]));
            }

            dgvItem.DataSource = products;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
