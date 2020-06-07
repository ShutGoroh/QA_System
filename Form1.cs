using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QA_System
{
    public partial class FormSign : Form
    {

        ModelQAContainer model;
        UserData userData;
        public FormSign()
        {
            InitializeComponent();
            model = new ModelQAContainer();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void Alert(string msg, Form_Alerts.enmType type)
        {
            Form_Alerts frm = new Form_Alerts();
            frm.showAlert(msg, type);
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            int _id = 0;
            string role = null;
            foreach(var ua in model.UserDatas)
            {
                if (ua.LoginUser == textBoxLogin.Text && ua.PasswordUser == textBoxPassword.Text)
                {
                    _id = ua.Id;
                    role = ua.RoleUser;
                }
            }
            if (role == "admin" && _id != -1)
            {
                this.Alert("Success", Form_Alerts.enmType.Success);
                this.Hide();
                userData = model.UserDatas.Find(_id);
                Form_Main_Admin main_Admin = new Form_Main_Admin(model, userData);
                main_Admin.Show();
            }
            else
            {
                if (role == "user" && _id != -1)
                {
                    this.Alert("Success", Form_Alerts.enmType.Success);
                    this.Hide();
                    userData = model.UserDatas.Find(_id);
                    Form_Main_User main_Admin = new Form_Main_User(model, userData);
                    main_Admin.Show();
                }
                else
                    this.Alert("Error", Form_Alerts.enmType.Error);
            }
        }

        #region
        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Пользователь")
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Teal;
            }
        }

        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = "Пользователь";
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Teal;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "Пароль";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void FormSign_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 12);
        }

        private void textBoxLogin_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Пользователь")
            {
                textBoxLogin.ForeColor = Color.Teal;
            }
        }

        private void textBoxLogin_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "Пользователь")
            {
                textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_MouseEnter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.ForeColor = Color.Teal;
            }
        }

        private void textBoxPassword_MouseLeave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "Пароль")
            {
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void gradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 12);
        }

        #endregion

        private void iconButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButtonClose_MouseEnter(object sender, EventArgs e)
        {
            iconButtonClose.ForeColor = Color.FromArgb(0, 192, 192);
            iconButtonClose.IconColor = Color.FromArgb(0, 192, 192);

        }

        private void iconButtonClose_MouseLeave(object sender, EventArgs e)
        {
            iconButtonClose.ForeColor = Color.Teal;
            iconButtonClose.IconColor = Color.Teal;
        }
    }
}
