using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace ScheduleProgram.Universal
{
    public class Appointment
    {
        //query to create appointment view for apptDgv
        public string apptQuery =
            "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end "
            + " FROM appointment "
            + " INNER JOIN customer ON appointment.customerId = customer.customerId;";
        public void PopulateAptData(string a, DataTable dt)
        {
            using (MySqlConnection connect = new MySqlConnection(DBConnector.ConnectionString))
            {
                MySqlCommand cmd = new MySqlCommand(a, connect);
                connect.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dt.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                        dt.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dt.Rows[i]["end"], TimeZoneInfo.Local).ToString();

                    }
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Can't get appointment information.");
                }
            }
        }
    }
}
