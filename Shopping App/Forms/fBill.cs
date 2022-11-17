using FontAwesome.Sharp;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fBill : Form
    {
        private string fileName;
        public fBill(string fn)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            fileName = fn;
        }

        private void fBill_Load(object sender, EventArgs e)
        {
            /*this.rpvBill.RefreshReport();
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(string));
            dt.Columns.Add("TenSP", typeof(string));
            dt.Columns.Add("SL", typeof(string));
            dt.Columns.Add("Gia", typeof(string));
            dt.Columns.Add("TT", typeof(string));

            dt.Rows.Add("1", "Nước tẩy rửa đa năng", "1", "123.000", "123.000");
            dt.Rows.Add("2", "Nước suối lavie chai 1 lít", "1", "123.000", "123.000");
            dt.Rows.Add("3", "Nước tăng lực String", "1", "123.000", "123.000");
            dt.Rows.Add("4", "Dầu ăn Simply chai 5 lít", "1", "123.000", "123.000");
            dt.Rows.Add("5", "Bánh gạo One One", "1", "123.000", "123.000");

            rpvBill.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rpvBill.LocalReport.ReportPath = "rptBill.rdlc"; //để file report trong Debug của project

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "dsReportBill"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            dts.Value = dt;
            rpvBill.LocalReport.DataSources.Clear();
            rpvBill.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "TenNV"; //Đặt đúng tên khi đặt trong report
            para1.Values.Add("Nguyễn Văn An");
            rpvBill.LocalReport.SetParameters(new ReportParameter[] { para1*//*, para2, para3, para4*//* });*/
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
