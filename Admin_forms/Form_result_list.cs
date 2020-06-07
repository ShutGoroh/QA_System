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
    public partial class Form_result_list : Form
    {
        ModelQAContainer model;

        public Form_result_list(ModelQAContainer _model)
        {
            InitializeComponent();
            model = _model;
            panelInformation.Visible = false;
            ShowList();
        }

        private void panelInformation_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowList()
        {
            TableResultList.DataSource = ( from u in model.UserDatas 
                                           join us in model.UserSystems 
                                           on u.Id equals us.UserDataId
                                           join s in model.SystemCollections 
                                           on us.SystemCollectionId equals s.Id
                                           where u.RoleUser == "user"
                                           select new
                                           {
                                               id = us.Id,
                                               Пользователь = u.NameUser,
                                               Система = s.SystemName
                                           }).ToList();
            TableResultList.Columns[TableResultList.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
            TableResultList.Update();
            TableResultList.Columns[0].Visible = false;
            TableResultList.ClearSelection();
        }

        private void TableResultList_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (TableResultList.SelectedRows.Count > 0)
            {
                UserSystems us = model.UserSystems.Find(TableResultList.SelectedRows[0].Cells[0].Value);
                labelUserName.Text = us.UserData.NameUser;
                labelSystemName.Text = us.SystemCollection.SystemName;
                labelNumberQuestions.Text = (from p in model.UserQuestions 
                                             where p.UserSystemsId == us.Id 
                                             select p).Count().ToString();
                labelNumberAnswers.Text = (from p in model.UserQuestions 
                                           where p.UserSystemsId == us.Id && p.DemandDescriptionId != null 
                                           select p).Distinct().Count().ToString();
                double a1 = (from p in model.UserQuestions
                            where p.UserSystemsId == us.Id
                            && p.DemandDescriptionId != null
                            select p.DemandDescriptionId).Distinct().Count();
                double b1 = (from a in model.DemandDescriptions
                             where a.TypeDemand.GroupDemand.SystemCollectionId == us.SystemCollectionId
                             select a).Count();
                double i = (double)a1/b1*100;
                labelProgress.Text = Math.Round(i,2).ToString()+"%";
                panelInformation.Visible = true;
            }
        }

        private void Form_result_list_Load(object sender, EventArgs e)
        {
            ShowList();
        }
    }
}
