using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ScheduleProgram
{
    public partial class UserReport : Form
    {
        private static DataManager universals = new DataManager();
        string getUsers = "SELECT userName from user;";
        int userId;
        public UserReport()
        {
            InitializeComponent();
            DataTable users = new DataTable();
            universals.GetData(getUsers, users);
            dropUser.DataSource = users;
            dropUser.DisplayMember = "userName";
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            getUserSchedules();
        }

        private void getUserSchedules()
        {
            {
                string userName = dropUser.GetItemText(dropUser.Text);
                string getUserId = "SELECT userId FROM user WHERE userName = '" + userName + "';";
                DataTable userIds = new DataTable();
                universals.TableReader(getUserId, userIds);

                if (userIds.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(userIds.Rows[0][0]);
                    userId = id;
                }

                string getSchedule = "SELECT appointmentId, customerId, type, start, end FROM appointment WHERE userId = '" + userId + "' ORDER BY start;";
                DataTable schedule = new DataTable();
                universals.TableReader(getSchedule, schedule);
                if (schedule.Rows.Count > 0)
                {
                    gridUser.DataSource = schedule;
                }
            }
        }

        private void userSchedule_Load(object sender, EventArgs e)
        {
            getUserSchedules();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }
    }
}
