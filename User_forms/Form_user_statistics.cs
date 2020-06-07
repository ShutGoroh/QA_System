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
    public partial class Form_user_statistics : Form
    {
        ModelQAContainer model;
        UserData user;

        public Form_user_statistics(ModelQAContainer _model, UserData _user)
        {
            InitializeComponent();
            model = _model;
            user = _user;
            ShowList();
        }

        private void ShowList()
        {
            TableResultList.DataSource = (from p in model.UserSystems
                                          where p.UserDataId == user.Id
                                          select new
                                          {
                                              id = p.Id,
                                              Наименование = p.SystemCollection.SystemName
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
                dataGridViewGeneral.DataSource = (from p in model.DemandDescriptions
                                                  join q in model.UserQuestions
                                                  on p.Id equals q.DemandDescriptionId
                                                  where p.TypeDemand.GroupDemand.GroupName == label1.Text + " " + us.SystemCollection.SystemName
                                                  && q.UserSystemsId == us.Id
                                                  select new
                                                  {
                                                      Раздел_требований=p.TypeDemand.TymeName,
                                                      Требование = p.Description
                                                  }).Distinct().ToList();
                dataGridViewGeneral.Columns[dataGridViewGeneral.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewGeneral.Update();
                dataGridViewGeneral.ClearSelection();
                dataGridViewFunctional.DataSource = (from p in model.DemandDescriptions
                                                  join q in model.UserQuestions
                                                  on p.Id equals q.DemandDescriptionId
                                                  where p.TypeDemand.GroupDemand.GroupName == label2.Text + " " + us.SystemCollection.SystemName
                                                  && q.UserSystemsId == us.Id
                                                  select new
                                                  {
                                                      Раздел_требований = p.TypeDemand.TymeName,
                                                      Требование = p.Description
                                                  }).Distinct().ToList();
                dataGridViewFunctional.Columns[dataGridViewFunctional.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewFunctional.Update();
                dataGridViewFunctional.ClearSelection();
                dataGridViewInterface.DataSource = (from p in model.DemandDescriptions
                                                  join q in model.UserQuestions
                                                  on p.Id equals q.DemandDescriptionId
                                                  where p.TypeDemand.GroupDemand.GroupName == label3.Text + " " + us.SystemCollection.SystemName
                                                  && q.UserSystemsId == us.Id
                                                  select new
                                                  {
                                                      Раздел_требований = p.TypeDemand.TymeName,
                                                      Требование = p.Description
                                                  }).Distinct().ToList();
                dataGridViewInterface.Columns[dataGridViewInterface.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewInterface.Update();
                dataGridViewInterface.ClearSelection();
                dataGridViewUnfunctional.DataSource = (from p in model.DemandDescriptions
                                                  join q in model.UserQuestions
                                                  on p.Id equals q.DemandDescriptionId
                                                  where p.TypeDemand.GroupDemand.GroupName == label4.Text + " " + us.SystemCollection.SystemName
                                                  && q.UserSystemsId == us.Id
                                                  select new
                                                  {
                                                      Раздел_требований = p.TypeDemand.TymeName,
                                                      Требование = p.Description
                                                  }).Distinct().ToList();
                dataGridViewUnfunctional.Columns[dataGridViewUnfunctional.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewUnfunctional.Update();
                dataGridViewUnfunctional.ClearSelection();
            }
        }
    }
}
