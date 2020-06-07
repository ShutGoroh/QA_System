using FontAwesome.Sharp;
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

namespace QA_System
{
    public partial class Form_Main_User : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        ModelQAContainer model;
        UserData user;
        public Form_Main_User(ModelQAContainer _model, UserData _user)
        {
            InitializeComponent();
            model = _model;
            user = _user;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 64);
            panelMenu.Controls.Add(leftBorderBtn);

        }
               
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.White;
                currentBtn.ForeColor = Color.Teal;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Teal;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Color.Teal;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconTitle.IconChar = currentBtn.IconChar;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Teal;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;

        }

        private void Form_Main_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSign formSign = new FormSign();
            this.Hide();
            formSign.Show();
        }

        private void ButtonAccountInfo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Form_account_info(model, user));
        }

        private void ButtonInterviewing_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new  User_forms.Form_interviewing(model,user));
        }

        private void ButtonStatistic_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new User_forms.Form_user_statistics(model, user));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            DisableButton();
            leftBorderBtn.Visible = false;
            lblTitleChildForm.Text = "Home";
            iconTitle.IconChar = IconChar.Home;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            FormSign formSign = new FormSign();
            this.Hide();
            formSign.Show();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 12);
        }
    }
}
