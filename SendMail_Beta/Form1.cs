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

namespace SendMail_Beta
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 74);
            panelMenu.Controls.Add(leftBorderBtn);

        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249,118,176);
            public static Color color3 = Color.FromArgb(95,77,221);
            public static Color color4 = Color.FromArgb(249,88,155);
            public static Color color5 = Color.FromArgb(95,77,221);
            public static Color color6 = Color.FromArgb(24,161,251);
        }

        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Left border
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //Icon Current Child
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new MailForm());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color2);
            OpenChildForm(new AboutForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Aqua;
            lblTitleChildForm.Text = "Home";
        }

    }
}
