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

namespace QA_System.User_forms
{
    public partial class Form_creation_new_user_system : Form
    {
        ModelQAContainer model;
        UserData user;

        public Form_creation_new_user_system(ModelQAContainer _model, UserData _user)
        {
            InitializeComponent();
            user = _user;
            model = _model;
            comboBoxSystems.DisplayMember = "SystemName";
            comboBoxSystems.DataSource = model.SystemCollections.ToList();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form_creation_new_user_form_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 12);
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            UserSystems user_Systems = new UserSystems();
            user_Systems.UserDataId = user.Id;
            user_Systems.UserData = user;
            user_Systems.SystemCollectionId = ((SystemCollection)(comboBoxSystems.SelectedValue)).Id;
            user_Systems.SystemCollection = model.SystemCollections.Find(((SystemCollection)(comboBoxSystems.SelectedValue)).Id);
            model.UserSystems.Add(user_Systems);
            model.SaveChanges();
            Close();
        }

        private void comboBoxSystems_SelectedIndexChanged(object sender, EventArgs e)
        {
            SystemCollection systemCollection = model.SystemCollections.Find(((SystemCollection)(comboBoxSystems.SelectedValue)).Id);
            textBoxDescription.Text = systemCollection.GeneralDescription;
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
