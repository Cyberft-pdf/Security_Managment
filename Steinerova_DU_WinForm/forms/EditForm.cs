using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecurityIncidents.Core.Entities;

namespace Steinerova_DU_WinForm.forms
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public Incident CreateSushi()
        {
            Incident newIncident = new Incident();

            newIncident.Name = textBox_Name.Text;
            newIncident.AttackMethod = textBox_Method.Text;
            newIncident.datumOfAttack = dateTimePicker_LastAttack.Value;
            newIncident.responsiblePerson = textBox_Person.Text;
            newIncident.IndicentLog = textBox_Log.Text;
            newIncident.ZeroDayExploit = checkBox_ZeroDayExploit.Checked;

            return newIncident;
        }


        public void LoadData(Incident incident)
        {

            textBox_Name.Text = incident.Name  ;
            textBox_Method.Text=incident.AttackMethod ;
            dateTimePicker_LastAttack.Value=incident.datumOfAttack ;
            textBox_Person.Text =incident.responsiblePerson  ;
            textBox_Log.Text= incident.IndicentLog ;

            checkBox_ZeroDayExploit.Checked =incident.ZeroDayExploit;
        }

        public void UpdateData(Incident incident)
        {

            incident.Name = textBox_Name.Text;
            incident.AttackMethod = textBox_Method.Text;
            incident.datumOfAttack = dateTimePicker_LastAttack.Value;
            incident.responsiblePerson = textBox_Person.Text;
            incident.IndicentLog = textBox_Log.Text;

            incident.ZeroDayExploit = checkBox_ZeroDayExploit.Checked;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
        }
    }
}
