using Microsoft.EntityFrameworkCore;
using SecurityIncidents.Core.Entities;
using SecurityIncidents.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ManagmentForm : Form
    {
        public BindingList<Incident> IncidentsData { get; set; }
        public SecurityIncidentsDbContext DbContext { get; set; }

        public ManagmentForm()
        {
            InitializeComponent();
        }

        private void ManagmentForm_Load(object sender, EventArgs e)
        {
            DbContext = new SecurityIncidentsDbContext();

            List<Incident> myIncident = DbContext.Incidents.ToList();

            IncidentsData = new BindingList<Incident>(myIncident);

            dataGridView_SecurityIncidents.DataSource = IncidentsData;

        }

        private void dataGridView_SecurityIncidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm();
            DialogResult saveResult = form.ShowDialog();
            if (saveResult == DialogResult.OK)
            {
                Incident newIncidents = form.CreateIncident();

                DbContext.Incidents.Add(newIncidents);
                DbContext.SaveChanges();

                IncidentsData.Add(newIncidents);
            }

        }

        private void button_edit_Click(object sender, EventArgs e)
        {

            if (dataGridView_SecurityIncidents.CurrentRow != null)
            {
                int index = dataGridView_SecurityIncidents.CurrentRow.Index;
                Incident incidentToUpdate = IncidentsData[index];

                EditForm incidentsEditForm = new EditForm();


                incidentsEditForm.LoadData(incidentToUpdate);


                DialogResult editResult = incidentsEditForm.ShowDialog();
                if (editResult == DialogResult.OK)
                {
                    incidentsEditForm.UpdateData(incidentToUpdate);

                    DbContext.Incidents.Update(incidentToUpdate);
                    DbContext.SaveChanges();

                    dataGridView_SecurityIncidents.Refresh();

                }

            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_SecurityIncidents.CurrentRow != null)
            {
                int index = dataGridView_SecurityIncidents.CurrentRow.Index;
                Incident sushiToRemove = IncidentsData[index];

                DbContext.Incidents.Remove(sushiToRemove);
                DbContext.SaveChanges();

                IncidentsData.Remove(sushiToRemove);
            }

        }
    }
}
