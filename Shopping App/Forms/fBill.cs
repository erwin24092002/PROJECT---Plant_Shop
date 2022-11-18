using FontAwesome.Sharp;
using Microsoft.Reporting.WinForms;
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
    public partial class fBill : Form
    {
        private string filePath;
        private DataTable plants = new MyData().Plants;
        public fBill(string fn)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            filePath = fn;
        }

        private void fBill_Load(object sender, EventArgs e)
        {

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            for (int i=5; i<lines.Count; i++)
            {
                string[] infor = lines[i].Split(',');
                string id = infor[0];
                int quantity = Int32.Parse(infor[1]);

                DataRow plant = plants.Select("id='" + id + "'")[0];
                dt.Rows.Add(plant["name"].ToString(), "$"+plant["price"].ToString(), quantity);
            }

            rpvBill.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //rpvBill.LocalReport.ReportPath = "Bill.rdlc"; //để file report trong Debug của project

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "CheckOutItem"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            dts.Value = dt;
            rpvBill.LocalReport.DataSources.Clear();
            rpvBill.LocalReport.DataSources.Add(dts);

            ReportParameter pCustomerName = new ReportParameter();
            pCustomerName.Name = "pCustomerName"; //Đặt đúng tên khi đặt trong report
            pCustomerName.Values.Add(lines[0]);

            ReportParameter pCustomerPhoneNumber = new ReportParameter();
            pCustomerPhoneNumber.Name = "pCustomerPhoneNumber"; //Đặt đúng tên khi đặt trong report
            pCustomerPhoneNumber.Values.Add(lines[1]);

            ReportParameter pCustomerAddress = new ReportParameter();
            pCustomerAddress.Name = "pCustomerAddress"; //Đặt đúng tên khi đặt trong report
            pCustomerAddress.Values.Add(lines[2]);

            ReportParameter pCustomerPaymentType = new ReportParameter();
            pCustomerPaymentType.Name = "pCustomerPaymentType"; //Đặt đúng tên khi đặt trong report
            pCustomerPaymentType.Values.Add(lines[3]);

            ReportParameter pDeliveryDate = new ReportParameter();
            pDeliveryDate.Name = "pDeliveryDate"; //Đặt đúng tên khi đặt trong report
            pDeliveryDate.Values.Add(lines[4]);

            rpvBill.LocalReport.SetParameters(new ReportParameter[] { pCustomerName, pCustomerPhoneNumber, pCustomerAddress, pCustomerPaymentType, pDeliveryDate });
            this.rpvBill.RefreshReport();

        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
