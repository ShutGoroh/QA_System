using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_System.Admin_forms
{
    public partial class Form_user_change : Form
    {
        ModelQAContainer model;
        UserData user;
        public Form_user_change(ModelQAContainer _model, UserData _user)
        {
            InitializeComponent();
            model = _model;
            user = _user;
            ShowUserData(user);
        }

        private void ShowUserData(UserData user)
        {
            textBoxName.Text = user.NameUser;
            switch(user.RoleUser)
            {
                case "user":
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                    return;
                case "admin":
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                    return;
            }
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            model.UserDatas.Remove(user);
            model.SaveChanges();
            Form_user_list form = new Form_user_list(model);
            form.ShowList();
            this.Close();            
        }
    }
}
