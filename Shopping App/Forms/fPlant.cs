using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping_App.Forms
{
    public partial class fPlant : Form
    {
        private DataRow plant;
        private IconButton currentBtn;
        private Panel botBorderBtn;
        private TextBox tbName = new TextBox();
        NumericUpDown nmStar = new NumericUpDown();
        RichTextBox rtbComment = new RichTextBox();

        public fPlant(string id)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            MyData data = new MyData();
            plant = data.Plants.Select("id=" + id)[0];

            ResourceManager PlantManager = new ResourceManager("Shopping_App.Plants", Assembly.GetExecutingAssembly());
            this.ptbPlant.BackgroundImage = (Image)PlantManager.GetObject(string.Join("_", plant["name"].ToString().Split(' ')));
            this.ptbPlant.BackgroundImageLayout = ImageLayout.Stretch;

            this.lbPlantName.Text = plant["name"].ToString();
            this.txbTotalPrice.Text = "$" + (float.Parse(plant["price"].ToString()) * (float)this.nmQuantity.Value).ToString();

            int num_star = Int32.Parse(plant["star"].ToString());
            int w = 30;
            int h = 30;
            int cur_x = 230 - w * num_star / 2;
            int cur_y = 40;
            for (int i = 1; i <= num_star; i++)
            {
                IconPictureBox star = new IconPictureBox();
                star.IconChar = IconChar.Star;
                star.ForeColor = Color.Gold;
                star.Location = new Point(cur_x, cur_y);
                star.Size = new Size(w, h);
                pPlantName.Controls.Add(star);
                cur_x += w;
            }

            botBorderBtn = new Panel();
            botBorderBtn.Size = new Size(184, 5);
            pControl2.Controls.Add(botBorderBtn);
            ActivateButton(btnDescription);
            Show_Description();
        }

        private void icExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nmQuantity_ValueChanged(object sender, EventArgs e)
        {
            this.txbTotalPrice.Text = "$" + (float.Parse(plant["price"].ToString()) * (float)this.nmQuantity.Value).ToString();
        }

        private void icExit_MouseHover(object sender, EventArgs e)
        {
            ((IconPictureBox)sender).ForeColor = Color.Red;
        }

        private void icExit_MouseLeave(object sender, EventArgs e)
        {
            ((IconPictureBox)sender).ForeColor = Color.Gainsboro;
        }

        private void Show_Description()
        {
            RichTextBox rtbDescription = new RichTextBox();
            int w = pPlantContent.Width - pPlantContent.Width / 10;
            int h = pPlantContent.Height - pPlantContent.Height / 10;
            int x = pPlantContent.Width / 20;
            int y = 10;
            rtbDescription.Size = new Size(w, h);
            rtbDescription.Location = new Point(x, y);
            rtbDescription.BorderStyle = BorderStyle.None;
            rtbDescription.Enabled = false;
            /*rtbDescription.BackColor = Color.Transparent;*/
            rtbDescription.Font = new Font("Arial", 15, FontStyle.Regular);
            rtbDescription.ForeColor = Color.Black;
            rtbDescription.Text = "Common Name: " + plant["common name"].ToString() + "\n" + plant["descript"].ToString();
            this.pPlantContent.Controls.Clear();
            this.pPlantContent.Controls.Add(rtbDescription);
        }

        private void btnDescription_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Show_Description();
        }

        private void Show_Review()
        {
            FlowLayoutPanel flpReview = new FlowLayoutPanel();
            int w = pPlantContent.Width;
            int h = 250;
            int x = 0;
            int y = 10;
            flpReview.Size = new Size(w, h);
            flpReview.Location = new Point(x, y);
            flpReview.BackColor = Color.WhiteSmoke;
            flpReview.AutoScroll = true;

            string filePath = "review/" + plant["id"].ToString() + ".txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            foreach(string line in lines)
            {
                string[] infor = line.Split(',');

                int w_review = w - 60;
                int h_review = 70;
                Panel review = new Panel();
                review.Size = new Size(w_review, h_review);
                review.Margin = new Padding(20, 10, 0, 0);
                review.BackColor = Color.Silver;

                Label review_name = new Label();
                review_name.AutoSize = true;
                review_name.Location = new Point(5, 2);
                review_name.Text = infor[0];
                review_name.Font = new Font("Arial", 9, FontStyle.Bold);
                review.Controls.Add(review_name);

                int num_star = Int32.Parse(infor[2]);
                int w_star = 20;
                int h_star = 20;
                for (int i = 1; i <= num_star; i++)
                {
                    IconPictureBox star = new IconPictureBox();
                    star.IconChar = IconChar.Star;
                    star.ForeColor = Color.Yellow;
                    star.Location = new Point(5+w_star*(i-1), 20);
                    star.Size = new Size(w_star, h_star);
                    review.Controls.Add(star);
                }

                Label rtbMessage = new Label();
                rtbMessage.Size = new Size(w_review - 10, 20);
                rtbMessage.Location = new Point(5, 41);
                rtbMessage.BorderStyle = BorderStyle.None;
                rtbMessage.Enabled = false;
                rtbMessage.Font = new Font("Arial", 9, FontStyle.Regular);
                rtbMessage.ForeColor = Color.Black;
                rtbMessage.Text = infor[1];
                review.Controls.Add(rtbMessage);

                flpReview.Controls.Add(review);
            }

            Label lbName = new Label();
            lbName.Text = "Name:";
            lbName.AutoSize = true;
            lbName.Location = new Point(15, 265);
            lbName.Font = new Font("Arial", 11, FontStyle.Bold);

            tbName.Size = new Size(200, 14);
            tbName.Location = new Point(90, 263);
            tbName.Font = new Font("Arial", 11, FontStyle.Bold);

            nmStar.Size = new Size(50, 14);
            nmStar.Location = new Point(370, 263);
            nmStar.Font = new Font("Arial", 11, FontStyle.Regular);
            nmStar.Minimum = 1;

            Label lbStar = new Label();
            lbStar.Text = "Star:";
            lbStar.AutoSize = true;
            lbStar.Location = new Point(310, 265);
            lbStar.Font = new Font("Arial", 11, FontStyle.Bold);

            rtbComment.Size = new Size(w-55, 40);
            rtbComment.Location = new Point(20, 295);
            rtbComment.Font = new Font("Arial", 11, FontStyle.Regular);
            rtbComment.Clear();

            IconButton icbtnComment = new IconButton();
            icbtnComment.Text = "Comment";
            icbtnComment.TextAlign = ContentAlignment.MiddleCenter;
            icbtnComment.Size = new Size(125, 30);
            icbtnComment.Location = new Point(300, 340);
            icbtnComment.ForeColor = Color.DodgerBlue;
            icbtnComment.Tag = filePath;
            icbtnComment.Click += btnComment_Click;

            this.pPlantContent.Controls.Clear();
            this.pPlantContent.Controls.Add(flpReview);
            this.pPlantContent.Controls.Add(lbName);
            this.pPlantContent.Controls.Add(tbName);
            this.pPlantContent.Controls.Add(lbStar);
            this.pPlantContent.Controls.Add(nmStar);
            this.pPlantContent.Controls.Add(rtbComment);
            this.pPlantContent.Controls.Add(icbtnComment);
        }

        private void btnComment_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(((IconButton)sender).Tag.ToString()).ToList();
            lines.Add(tbName.Text + "," + rtbComment.Text + "," + nmStar.Value.ToString());
            File.WriteAllLines(((IconButton)sender).Tag.ToString(), lines.ToArray());
            Show_Review();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Show_Review();
        }


        private void btnCart_Click(object sender, EventArgs e)
        {
            string filePath = @"cart.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();
            string date = DateTime.Now.ToString("MMMM dd, yyyy");
            lines.Add(plant["id"].ToString() + "," + this.nmQuantity.Value.ToString() + "," + date);
            File.WriteAllLines(filePath, lines.ToArray());
            MessageBox.Show("Add \"" + plant["name"] + "\" to cart successfully");
            this.Close();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            this.Hide();
            List<string> lines = new List<string>();
            lines.Add(plant["id"].ToString() + "," + this.nmQuantity.Value.ToString() + "," + DateTime.Now.ToString("MMMM dd, yyyy"));
            fCheckOut f = new fCheckOut(lines);
            f.ShowDialog();
            this.Close();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.WhiteSmoke;
                currentBtn.ForeColor = Color.DodgerBlue;
                currentBtn.IconColor = Color.DodgerBlue;

                // Bot border button
                botBorderBtn.BackColor = Color.DodgerBlue;
                botBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                botBorderBtn.Visible = true;
                botBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                // Button
                currentBtn.BackColor = Color.FromArgb(0, 78, 100);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
    }
}
