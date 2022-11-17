using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Shopping_App.Forms;

namespace Shopping_App
{
    public partial class fMainMenu : Form
    {
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        // Constructor
        public fMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            pMenu.Controls.Add(leftBorderBtn);
            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        // Structss
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(154, 193, 240);
            public static Color color2 = Color.FromArgb(114, 250, 147);
            public static Color color3 = Color.FromArgb(160, 229, 72);
            public static Color color4 = Color.FromArgb(228, 95, 43);
            public static Color color5 = Color.FromArgb(246, 196, 69);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        // Methods
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(19, 159, 100);
                currentBtn.ForeColor = RGBColors.color3;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = RGBColors.color3;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = RGBColors.color3;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                // Button
                currentBtn.BackColor = Color.FromArgb(11, 95, 60);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.Size = this.pDesktop.Size;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pDesktop.Controls.Add(childForm);
            pDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fShop());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fCart());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fBlog());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fHistory());
        }
        private void btnMarketing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fContactUs());
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new fSetting());
        }
        private void btnLogo_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }

        // Drag Form
        [DllImport("user3.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SenMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void lbTitleChileForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icZoomOut_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            icZoomIn.Visible = true;
            icZoomOut.Visible = false;
        }

        private void icMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void icZoomIn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            icZoomIn.Visible = false;
            icZoomOut.Visible = true;
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
