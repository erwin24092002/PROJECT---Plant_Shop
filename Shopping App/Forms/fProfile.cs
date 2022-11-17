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
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fProfile : Form
    {
        public fProfile()
        {
            InitializeComponent();
            BillRender();
        }
        private void BillRender()
        {
            flpBill.Controls.Clear();
            string[] fileNames = Directory.GetFiles(@"bill/", "*.txt");
            foreach (string fileName in fileNames)
            {
                ReceiptItem rItem = new ReceiptItem(fileName);
                rItem.icbtnBillDisplay.Click += btnView_Click;
                rItem.icbtnBillDisplay.Tag = fileName;
                this.flpBill.Controls.Add(rItem);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string fn = ((IconButton)sender).Tag.ToString();
            fBill f = new fBill(fn);
            f.ShowDialog();
        }
    }
    
}
