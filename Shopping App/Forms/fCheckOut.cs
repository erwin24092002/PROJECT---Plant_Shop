using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace Shopping_App.Forms
{
    public partial class fCheckOut : Form
    {
        List<string> org_lines = new List<string>();
        List<string> lines = new List<string>();
        DataTable plants = new MyData().Plants;
        DataTable products = new DataTable();
        public fCheckOut(List<string> l)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            org_lines = l;
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
            lsvProduct.Items.Clear();
            float totalcost = 0;
            foreach (DataRow product in products.Rows)
            {
                ListViewItem lsvItem = new ListViewItem(product["name"].ToString());
                lsvItem.SubItems.Add("$"+product["price"].ToString());
                lsvItem.SubItems.Add(product["quantity"].ToString());
                lsvItem.SubItems.Add("$" + (float.Parse(product["price"].ToString()) * Int32.Parse(product["quantity"].ToString())).ToString());
                lsvProduct.Items.Add(lsvItem);
                totalcost += float.Parse(product["price"].ToString()) * Int32.Parse(product["quantity"].ToString());
            }
            
            this.dtpDeliverDate.Value = DateTime.Now.AddDays(4);
            this.txbTotalCost.Text = "$" + totalcost.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (false)
            {
                MessageBox.Show("You need to enter full information before payment!");
            }
            else
            {
                string filePath = @"cart.txt";
                List<string> cart_lines = new List<string>();
                List<string> new_lines = new List<string>();
                cart_lines = File.ReadAllLines(filePath).ToList();
                foreach (string cart_line in cart_lines)
                {
                    int flag = 1;
                    foreach (string org_line in org_lines)
                        if (cart_line == org_line)
                            flag = 0;
                    if (flag == 1)
                        new_lines.Add(cart_line);
                }
                File.WriteAllLines(filePath, new_lines.ToArray());

                string billPath = "bill/" + DateTime.Now.ToString("HH mm ss - MMMM dd yyyy") + ".txt";
                List<string> infor = new List<string>();
                FileStream billFile = File.Create(billPath);
                billFile.Close();

                infor.Add(txbName.Text);
                infor.Add(txbPhoneNumber.Text);
                infor.Add(txbAddress.Text);
                infor.Add(cbPaymentType.Text);
                infor.Add(dtpDeliverDate.Text);
                infor.Add(txbDiscount.Text.Split('%')[0]);
                foreach(string line in lines)
                    infor.Add(line);
                File.WriteAllLines(billPath, infor.ToArray());

                MessageBox.Show("You paid successfully!");
                this.Close();
            }
        }
    }
}
