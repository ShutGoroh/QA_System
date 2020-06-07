using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_System
{
    public partial class Form_account_info : Form
    {
        ModelQAContainer model;
        UserData userData;
        Regex checkText = new Regex(@"\w");

        public Form_account_info(ModelQAContainer _model, UserData _userInfo)
        {
            InitializeComponent();
            model = _model;
            userData = _userInfo;
            //User Information
            textBoxName.Text = userData.NameUser.ToString();
            this.Text = userData.LoginUser.ToString();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            ChangeUserData();
        }

        public void Alert(string msg, Form_Alerts.enmType type)
        {
            Form_Alerts frm = new Form_Alerts();
            frm.showAlert(msg, type);
        }

        private void ChangeUserData()
        {
            if (checkText.IsMatch(textBoxName.Text))
            {
                userData.NameUser = textBoxName.Text;
                this.Alert("Name", Form_Alerts.enmType.Success);
            }
            else
            {
                this.Alert("Name", Form_Alerts.enmType.Error);
            }

            if (textBoxOldPassword.Text!= "")
            {
                if (textBoxOldPassword.Text == userData.PasswordUser
                    && checkText.IsMatch(textBoxNewPassword.Text) && checkText.IsMatch(textBoxReturnPassword.Text)
                    && textBoxNewPassword.Text == textBoxReturnPassword.Text)
                {
                    userData.PasswordUser = textBoxNewPassword.Text;
                    this.Alert("Password", Form_Alerts.enmType.Success);
                }
                else
                {
                    this.Alert("Password", Form_Alerts.enmType.Error);
                }
            }
            model.SaveChanges();


        }

    }
}
