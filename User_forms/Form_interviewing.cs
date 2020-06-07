using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QA_System.User_forms
{
    public partial class Form_interviewing : Form
    {
        ModelQAContainer model;
        UserData user;

        private Form currentChildForm;

        public Form_interviewing(ModelQAContainer _model, UserData _user)
        {
            InitializeComponent();
            model = _model;
            user = _user;
            ShowComboBox();
        }

        private void ShowComboBox()
        {
            var uus = (from us in model.UserSystems
                      join s in model.SystemCollections
                      on us.SystemCollectionId equals s.Id
                       where us.UserDataId == user.Id
                      select new
                      {
                          us.Id,
                          Система = s.SystemName
                      }).ToList();
            comboBoxUserSystems.DataSource = uus;
            comboBoxUserSystems.DisplayMember = "Система";
            comboBoxUserSystems.ValueMember = "id";
        }

        private void comboBoxUserSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserSystems systemCollection = model.UserSystems.Find(comboBoxUserSystems.SelectedValue);
            textBoxDescription.Text = systemCollection.SystemCollection.GeneralDescription;

            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Form_for_chat chat = new Form_for_chat(model, systemCollection);
            currentChildForm = chat;

            chat.TopLevel = false;
            chat.FormBorderStyle = FormBorderStyle.None;
            chat.Dock = DockStyle.Fill;
            panelForChat.Controls.Add(chat);
            panelForChat.Tag = chat;
            chat.BringToFront();
            chat.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_creation_new_user_system form = new Form_creation_new_user_system(model, user);
            form.ShowDialog();
            ShowComboBox();
        }
    }
}
