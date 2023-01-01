using System;
using System.Data;
using System.Drawing; 
using System.Windows.Forms;
using ScheduleProgram.Universal;

namespace ScheduleProgram
{
    public partial class MainForm : Form
    {
        private static Customer customer = new Customer();
        private static Appointment appointment = new Appointment();
        private static DataManager dataManager = new DataManager();
        
        public delegate string GoodBye(string name);
        DataTable custDt = new DataTable();
        DataTable aptDt = new DataTable();
        DateTime selectedDate = new DateTime();



        public MainForm()
        {
            InitializeComponent();

            selectedDate = DateTime.Now;
            calAptView.AddBoldedDate(selectedDate);

            DataManager.CurrentCustomerIndex = -1;
            customer.PopulateCustData(customer.findAllCustQuery, custDt);
            gridCustomers.RowHeadersVisible = false;
            gridCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridCustomers.DefaultCellStyle.SelectionForeColor = gridCustomers.DefaultCellStyle.ForeColor;
            gridCustomers.DataSource = custDt;
            gridCustomers.Columns["country"].Visible = false;
            gridCustomers.Columns["customerId"].Visible = false;
            DataManager.CurrentAptIndex = -1;
            appointment.PopulateAptData(appointment.apptQuery, aptDt);
            gridAppointments.RowHeadersVisible = false;
            gridAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridAppointments.DefaultCellStyle.SelectionForeColor = gridAppointments.DefaultCellStyle.ForeColor;
            gridAppointments.DataSource = aptDt;
            gridAppointments.Columns["customerId"].Visible = false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DataManager.CustomerID = 0;
            this.Hide();
            CustomerForm newCust = new CustomerForm();
            newCust.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Confirm that logout was successful. Use lambda to shorten syntax.
            GoodBye obj = (currentUserName) => { return currentUserName + ", you have successfully logged out."; };
            string GoodBye = obj.Invoke(DataManager.CurrentUser);
            MessageBox.Show(GoodBye);
            Application.Exit();
        }

        private void btnAddApt_Click(object sender, EventArgs e)
        {
            DataManager.CustomerID = 0;
            DataManager.AppointmentID = 0;
            this.Hide();
            AptForm newAppt = new AptForm();
            newAppt.Show();
        }

        private void radDay_CheckedChanged(object sender, EventArgs e)
        {
            HandleDay();
        }

        private void radWeek_CheckedChanged(object sender, EventArgs e)
        {
            HandleWeek();
        }

        private void radMonth_CheckedChanged(object sender, EventArgs e)
        {
            HandleMonth();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (DataManager.CurrentCustomerIndex >= 0)
            {
                string selectCust = "SELECT * FROM customer;";
                DataTable custToUpdate = new DataTable();
                dataManager.TableReader(selectCust, custToUpdate);
                if (custToUpdate.Rows.Count > 0)
                {
                    int custId = (int)custToUpdate.Rows[DataManager.CurrentCustomerIndex]["customerId"];
                    DataManager.CustomerID = custId;
                }
                this.Hide();
                CustomerForm editCust = new CustomerForm();
                editCust.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer to update.");
            }
        }
        private void btnUpdateApt_Click(object sender, EventArgs e)
        {
            if (DataManager.CurrentAptIndex >= 0)
            {
                string selectAppt = "SELECT * FROM appointment;";
                DataTable apptToUpdate = new DataTable();
                dataManager.TableReader(selectAppt, apptToUpdate);
                if (apptToUpdate.Rows.Count > 0)
                {
                    int appointId = (int)apptToUpdate.Rows[DataManager.CurrentAptIndex]["appointmentId"];
                    DataManager.AppointmentID = appointId;
                }
                this.Hide();
                AptForm editAppt = new AptForm();
                editAppt.Show();
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }
        private void dataCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataManager.CurrentCustomerIndex = e.RowIndex;
            gridCustomers.DefaultCellStyle.SelectionBackColor = Color.Blue;
 
        }
        private void dataApt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataManager.CurrentAptIndex = e.RowIndex;
            gridAppointments.DefaultCellStyle.SelectionBackColor = Color.Blue;
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (DataManager.CurrentCustomerIndex >= 0)
            {
                DataTable deleteCust = new DataTable();
                dataManager.TableReader(customer.findAllCustQuery, deleteCust);
                DataManager.CustomerID = (int)deleteCust.Rows[DataManager.CurrentCustomerIndex]["customerId"];
                DataTable deleteAddress = new DataTable();
                string addressToDelete = "SELECT addressId from customer WHERE customerId = '" + DataManager.CustomerID + "';";
                dataManager.TableReader(addressToDelete, deleteAddress);

                DataManager.AddressID = (int)deleteAddress.Rows[0][0];

                if (DataManager.CustomerID != 0)
                {

                    string deleteCustomerAndAddress = "DELETE customer FROM customer WHERE customerId = '" + DataManager.CustomerID + "';" +
                            "DELETE address FROM address WHERE addressId = '" + DataManager.AddressID + "';";


                    DialogResult dialogResult = MessageBox.Show("This will permanently delete the customer. Continue?", "", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            DataTable customerDeleteCompleted = new DataTable();
                            dataManager.ExecuteNonQueryUpdater(deleteCustomerAndAddress);
                            dataManager.GetData(customer.findAllCustQuery, customerDeleteCompleted);
                            gridCustomers.DataSource = customerDeleteCompleted;
                        }
                        catch
                        {
                            MessageBox.Show("Unable to delete customer. Recommend checking for currently scheduled appointments for selected customer.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void btnDeleteApt_Click(object sender, EventArgs e)
        {
            if (DataManager.CurrentAptIndex >= 0)
            {
                DataTable deleteAppointment = new DataTable();
                dataManager.TableReader(appointment.apptQuery, deleteAppointment);
                DataManager.AppointmentID = (int)deleteAppointment.Rows[DataManager.CurrentAptIndex]["appointmentId"];

                if (DataManager.AppointmentID != 0)
                {
                    string deleteSelectedAppointment = "DELETE appointment FROM appointment WHERE appointmentId = '" + DataManager.AppointmentID + "';";

                    DialogResult dialog = MessageBox.Show("Are you sure you want to delete this appointment?", "", MessageBoxButtons.YesNo);

                    if (dialog == DialogResult.Yes)
                    {
                        dataManager.ExecuteNonQueryUpdater(deleteSelectedAppointment);
                        DataTable appointmentDeleted = new DataTable();
                        dataManager.GetData(appointment.apptQuery, appointmentDeleted);
                        gridAppointments.DataSource = appointmentDeleted;

                        this.Hide();
                        MainForm dash = new MainForm();
                        dash.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete.");
            }
        }

        private void HandleDay()
        {
            calAptView.MaxSelectionCount = 1;
            DateTime dayStart = new DateTime();
            DateTime dayEnd = new DateTime();

            dayStart = selectedDate;
            dayEnd = selectedDate.AddDays(0);

            calAptView.SetSelectionRange(dayStart, dayEnd);

            string todayAppt = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end  FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN  '" +
                TimeZoneInfo.ConvertTimeToUtc(dayStart).ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(dayEnd).ToString("yyyy-MM-dd HH:mm:ss") + "' ;";

            DataTable handleDay = new DataTable();
            dataManager.TableReader(todayAppt, handleDay);

            if (handleDay.Rows.Count > 0)
            {
                for (int i = 0; i < handleDay.Rows.Count; i++)
                {
                    gridAppointments.DataSource = handleDay;
                    handleDay.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleDay.Rows[i]["start"],
                        TimeZoneInfo.Local).ToString();
                    handleDay.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleDay.Rows[i]["end"],
                        TimeZoneInfo.Local).ToString();
                }
            }
            else
            {
                MessageBox.Show("No appointments found for this date.");
            }
        }

        private void HandleWeek()
        {
            calAptView.MaxSelectionCount = 7;
            DateTime weekStart = new DateTime();
            DateTime weekEnd = new DateTime();

            weekStart = selectedDate;
            weekEnd = selectedDate.AddDays(6);
            calAptView.SetSelectionRange(weekStart, weekEnd);

            string weekAppts = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end  FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN '" +
                TimeZoneInfo.ConvertTimeToUtc(weekStart).ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(weekEnd).ToString("yyyy-MM-dd HH:mm:ss") + "' ;";

            DataTable handleWeek = new DataTable();
            dataManager.TableReader(weekAppts, handleWeek);
            if (handleWeek.Rows.Count > 0)
            {
                for (int i = 0; i < handleWeek.Rows.Count; i++)
                {
                    gridAppointments.DataSource = handleWeek;
                    handleWeek.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleWeek.Rows[i]["start"],
                        TimeZoneInfo.Local).ToString();
                    handleWeek.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleWeek.Rows[i]["end"],
                        TimeZoneInfo.Local).ToString();
                }
            }
            else
            {
                MessageBox.Show("No appointments found for this date range.");
            }
        }

        private void HandleMonth()
        {
            calAptView.MaxSelectionCount = 31;
            DateTime monthStart = new DateTime();
            DateTime monthEnd = new DateTime();
            monthStart = selectedDate;
            monthEnd = selectedDate.AddDays(30);
            calAptView.SetSelectionRange(monthStart, monthEnd);

            string monthAppts = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.type, appointment.start, appointment.end FROM " +
                "appointment INNER JOIN customer ON appointment.customerId = customer.customerId WHERE appointment.start BETWEEN '" +
                    TimeZoneInfo.ConvertTimeToUtc(monthStart).ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" + TimeZoneInfo.ConvertTimeToUtc(monthEnd).ToString("yyyy-MM-dd HH:mm:ss") + "' ;";

            DataTable handleMon = new DataTable();
            dataManager.TableReader(monthAppts, handleMon);

            if (handleMon.Rows.Count > 0)
            {
                //Time conversion
                for (int i = 0; i < handleMon.Rows.Count; i++)
                {
                    gridAppointments.DataSource = handleMon;
                    handleMon.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleMon.Rows[i]["start"],
                        TimeZoneInfo.Local).ToString();
                    handleMon.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)handleMon.Rows[i]["end"],
                        TimeZoneInfo.Local).ToString();
                }
            }
            else
            {
                MessageBox.Show("No appointments found for this date range.");
            }
        }
    
        private void calMyView_DateSelected(object sender, DateRangeEventArgs e)
        {
            selectedDate = e.Start;
          
           if (radMonth.Checked)
            {
                HandleMonth();
                
            }
            else
            {
                if (radDay.Checked)
                {
                    HandleDay();
                }
                else
                {
                    HandleWeek();
                }
            }
             
        }

        private void btnAptByMonth_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthAptReport monReport = new MonthAptReport();
            monReport.Show();
        }
        private void btnAptByCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerAptReport custReport = new CustomerAptReport();
            custReport.Show();
        }
        private void btnUserSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserReport userSched = new UserReport();
            userSched.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string customerText = txtSearch.Text;
            DataTable customerSearchResult = new DataTable();

            string searchParams = "SELECT customerId, customerName, address.address, city.city, address.postalCode, country.country, address.phone "
            + "FROM customer "
            + "INNER JOIN address ON customer.addressId = address.addressId "
            + "INNER JOIN city ON address.cityId = city.cityId "
            + "INNER JOIN country on city.countryId = country.countryId "
            + "WHERE customerName LIKE \"%" + customerText + "%\";";

            dataManager.TableReader(searchParams, customerSearchResult);

            if (customerSearchResult.Rows.Count > 0)
            {
                gridCustomers.DataSource = customerSearchResult;
                gridCustomers.RowHeadersVisible = false;
                gridCustomers.Columns["country"].Visible = false;
                gridCustomers.Columns["customerId"].Visible = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void lblReports_Click(object sender, EventArgs e)
        {

        }

        private void calAptView_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
