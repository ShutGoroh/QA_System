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
    public partial class Form_user_list : Form
    {
        ModelQAContainer model;
        UserData selectedUser;
        private Form currentChildForm;

        public Form_user_list(ModelQAContainer _model)
        {
            InitializeComponent();
            model = _model;
            ShowList();
            TableUserList.ClearSelection();
        }

        public void ShowList()
        {
            TableUserList.DataSource = (from p in model.UserDatas where p.Hidden == false
                                               select new
                                               {
                                                   id = p.Id,
                                                   Логин = p.LoginUser,
                                                   Имя = p.NameUser,
                                                   Роль = p.RoleUser
                                               }).ToList();
            TableUserList.Columns[TableUserList.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TableUserList.ClearSelection();
            TableUserList.Update();
            TableUserList.Columns[0].Visible = false;
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
            panelUserData.Controls.Add(childForm);
            panelUserData.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void TableUserList_Click(object sender, EventArgs e)
        {
            if (TableUserList.SelectedRows.Count > 0)
            {
                selectedUser = model.UserDatas.Find(TableUserList.SelectedRows[0].Cells[0].Value);
                OpenChildForm(new Form_user_change(model, selectedUser));
            }
            ShowList();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            Form_user_creation user_Creation = new Form_user_creation(model);
            user_Creation.ShowDialog();
            ShowList();
            TableUserList.ClearSelection();
        }

        private void Form_user_list_Load(object sender, EventArgs e)
        {
            TableUserList.ClearSelection();
        }
    }
}
