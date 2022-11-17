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
    public class ReceiptItem : Panel
    {
        public string fileName;
        public Label lbBillName = new Label();
        public Label lbBillDate = new Label();
        public IconButton icbtnBillDisplay = new IconButton();

        public ReceiptItem(string fn)
        {
            this.Size = new Size(800, 100);
            this.BackColor = Color.White;
            this.Margin = new Padding(10, 10, 10, 10);
            this.fileName = fn;

            lbBillName.Text = "Receipt";
            lbBillName.TextAlign = ContentAlignment.MiddleCenter;
            lbBillName.Location = new Point(50, 38);
            lbBillName.Font = new Font("Arial", 15, FontStyle.Bold);
            lbBillName.AutoSize = true;
            lbBillName.ForeColor = Color.LightGray;

            string[] time = fileName.Split(' ');
            lbBillDate.Text = time[0].Split('/')[1] + ":" + time[1] + ":" + time[2] + " - " + time[4] + " " + time[5] + ", " + time[6].Split('.')[0];
            lbBillDate.TextAlign = ContentAlignment.MiddleRight;
            lbBillDate.Location = new Point(550, 5);
            lbBillDate.Font = new Font("Arial", 10, FontStyle.Regular);
            lbBillDate.AutoSize = true;
            lbBillDate.ForeColor = Color.LightGray;

            icbtnBillDisplay.Size = new Size(200, 50);
            icbtnBillDisplay.Location = new Point(578, 30);
            icbtnBillDisplay.IconChar = IconChar.Print;
            icbtnBillDisplay.ImageAlign = ContentAlignment.MiddleLeft;
            icbtnBillDisplay.Text = "View";
            icbtnBillDisplay.TextAlign = ContentAlignment.MiddleCenter;
            icbtnBillDisplay.ForeColor = Color.FromArgb(194, 24, 7);

            this.Controls.Add(lbBillName);
            this.Controls.Add(lbBillDate);
            this.Controls.Add(icbtnBillDisplay);
        }
    }
}