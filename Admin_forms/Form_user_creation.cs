using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_System.Admin_forms
{
    public partial class Form_user_creation : Form
    {
        ModelQAContainer model;
        Regex checkText = new Regex(@"\w");

        public Form_user_creation(ModelQAContainer _modelQAContainer)
        {
            InitializeComponent();
            model = _modelQAContainer;
            radioButton1.Checked = true;
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

        private void User_creation()
        {
            UserData userData = new UserData();
            if (checkText.IsMatch(textBoxLogin.Text) &&
                checkText.IsMatch(textBoxName.Text) &&
                checkText.IsMatch(textBoxPassword.Text) &&
                checkText.IsMatch(textBoxReturnPassword.Text)
                    && textBoxPassword.Text == textBoxReturnPassword.Text)
            {
                userData.LoginUser = textBoxLogin.Text;
                userData.NameUser = textBoxName.Text;
                userData.PasswordUser = textBoxPassword.Text;
                if (radioButton1.Checked == true)
                    userData.RoleUser = "user";
                else
                    userData.RoleUser = "admin";
                userData.Hidden = false;
                model.UserDatas.Add(userData);
                model.SaveChanges();
                Alert("Success", Form_Alerts.enmType.Success);
                this.Close();
            }
            else
            {
                Alert("Error", Form_Alerts.enmType.Error);
            }

        }

        private void Form_user_creation_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 12);
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            User_creation();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
