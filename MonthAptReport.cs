using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScheduleProgram
{
    public partial class MonthAptReport : Form
    {
        string date;
        private static DataManager universals = new DataManager();

        public MonthAptReport()
        {
            InitializeComponent();
            dropMonth.Items.Add("Sep 2022");
            dropMonth.Items.Add("Oct 2022");
            dropMonth.Items.Add("Nov 2022");
            dropMonth.Items.Add("Dec 2022");
            dropMonth.Items.Add("Jan 2023");
            dropMonth.Items.Add("Feb 2023");
        }
        

      

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (dropMonth.GetItemText(dropMonth.Text) == "Sep 2022")
            {
                date = "2022-09%";
            }
            else if (dropMonth.GetItemText(dropMonth.Text) == "Oct 2022")
            {
                date = "2020-10%";
            }
            else if (dropMonth.GetItemText(dropMonth.Text) == "Nov 2022")
            {
                date = "2022-11%";
            }
            else if (dropMonth.GetItemText(dropMonth.Text) == "Dec 2022")
            {
                date = "2022-12%";
            }
            else if (dropMonth.GetItemText(dropMonth.Text) == "Jan 2023")
            {
                date = "2023-01%";
            }
            else if (dropMonth.GetItemText(dropMonth.Text) == "Feb 2023")
            {
                date = "2023-02%";
            }
            else
            {
                MessageBox.Show("Please select a month.");
            }

            string selectAllAppointmentsMonth = "SELECT  appointmentId, customerId, type FROM appointment WHERE start LIKE '" + date + "';";
            DataTable allAptData = new DataTable();
            universals.TableReader(selectAllAppointmentsMonth, allAptData);
            gridAptByMonth.DataSource = allAptData;

            string selectDemoAppoinmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Demo';";
            DataTable demo = new DataTable();
            universals.TableReader(selectDemoAppoinmentMonth, demo);
            if (demo.Rows.Count > 0)
            {
                demoCount.Text = demo.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No demo appointments this month.");
            }
            string selectContractReviewAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Contract Review';";
            DataTable contract = new DataTable();
            universals.TableReader(selectContractReviewAppointmentMonth, contract);
            if (contract.Rows.Count > 0)
            {
                contractReviewCount.Text = contract.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No contract review appointments this month");
            }
            string selectPresentationAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Presentation';";
            DataTable presentation = new DataTable();
            universals.TableReader(selectPresentationAppointmentMonth, presentation);
            if (presentation.Rows.Count > 0)
            {
                presentationCount.Text = presentation.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No presentation appointments this month.");
            }
            string selectScrumAppointmentMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "' and type = 'Scrum';";
            DataTable scrum = new DataTable();
            universals.TableReader(selectScrumAppointmentMonth, scrum);
            if (scrum.Rows.Count > 0)
            {
                scrumCount.Text = scrum.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No scrum appointments this month.");
            }

            string selectAppointmentCountMonth = "SELECT COUNT(*) FROM appointment WHERE start LIKE '" + date + "';";
            DataTable all = new DataTable();
            universals.TableReader(selectAllAppointmentsMonth, all);
            if (all.Rows.Count > 0)
            {
                totalCount.Text = all.Rows[0][0].ToString();
            }
            else
            {
                MessageBox.Show("No Appointments scheduled this Month.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void MonthAptReport_Load(object sender, EventArgs e)
        {

        }
    }
}
