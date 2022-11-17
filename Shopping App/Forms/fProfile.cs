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
                Panel billItem = new Panel();
                billItem.Size = new Size(800, 100);
                billItem.BackColor = Color.White;
                billItem.Margin = new Padding(10, 10, 10, 10);

                Label lbBillName = new Label();
                lbBillName.Text = "Receipt";
                lbBillName.TextAlign = ContentAlignment.MiddleCenter;
                lbBillName.Location = new Point(50, 38);
                lbBillName.Font = new Font("Arial", 15, FontStyle.Bold);
                lbBillName.AutoSize = true;
                lbBillName.ForeColor = Color.LightGray;

                string[] time = fileName.Split(' ');
                Label lbBillDate = new Label();
                lbBillDate.Text = time[0].Split('/')[1] + ":" + time[1] + ":" + time[2] + " - " + time[4] + " "  + time[5] + ", " + time[6].Split('.')[0];
                lbBillDate.TextAlign = ContentAlignment.MiddleRight;
                lbBillDate.Location = new Point(550, 5);
                lbBillDate.Font = new Font("Arial", 10, FontStyle.Regular);
                lbBillDate.AutoSize = true;
                lbBillDate.ForeColor = Color.LightGray;

                IconButton icbtnBillDisplay = new IconButton();
                icbtnBillDisplay.Size = new Size(200, 50);
                icbtnBillDisplay.Location = new Point(578, 30);
                icbtnBillDisplay.IconChar = IconChar.SquareXmark;
                icbtnBillDisplay.ImageAlign = ContentAlignment.MiddleLeft;
                icbtnBillDisplay.Text = "View";
                icbtnBillDisplay.TextAlign = ContentAlignment.MiddleCenter;
                icbtnBillDisplay.ForeColor = Color.FromArgb(194, 24, 7);
                icbtnBillDisplay.Tag = fileName;
                icbtnBillDisplay.Click += btnView_Click;

                billItem.Controls.Add(lbBillName);
                billItem.Controls.Add(lbBillDate);
                billItem.Controls.Add(icbtnBillDisplay);

                this.flpBill.Controls.Add(billItem);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            fBill f = new fBill();
            f.ShowDialog();
        }
    }
    
}
