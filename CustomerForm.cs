using ScheduleProgram.Universal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Markup;
using System.Text.RegularExpressions;

namespace ScheduleProgram
{
    public partial class CustomerForm : Form
    {

        public static int cID;
        public static int aID;
        private static Customer customer = new Customer();
        private static DataManager universals = new DataManager();

        private bool SaveAllowed()
        {
            if (!universals.IsNotNullOrEmpty(txtName.Text))
            { return false; }
            if (!universals.IsNotNullOrEmpty(txtAddress.Text))
            { return false; }
            if (!universals.IsNotNullOrEmpty(txtZip.Text))
            { return false; }
            if (!universals.IsNotNullOrEmpty(txtPhone.Text))
            { return false; }
            return true;
        }
        public CustomerForm()
        {
            string city = "SELECT city from city;";
            DataTable cityDt = new DataTable();
            InitializeComponent();
            universals.GetData(city, cityDt);
            dropCity.DataSource = cityDt;
            dropCity.DisplayMember = "City";


        if (DataManager.CustomerID > 0)
            {
                DataTable customerFill = new DataTable();
                string custInfo = customer.findAllCustQuery;

                universals.TableReader(custInfo, customerFill);
                txtName.Text = (string)customerFill.Rows[DataManager.CurrentCustomerIndex]["customerName"];
                txtAddress.Text = (string)customerFill.Rows[DataManager.CurrentCustomerIndex]["address"];
                txtZip.Text = (string)customerFill.Rows[DataManager.CurrentCustomerIndex]["postalCode"];
                txtPhone.Text = (string)customerFill.Rows[DataManager.CurrentCustomerIndex]["phone"];
                dropCity.Text = (string)customerFill.Rows[DataManager.CurrentCustomerIndex]["city"];
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm dash = new MainForm();
            dash.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (DataManager.CustomerID > 0)
            {
                UpdateCustomerData();
            }
            else
            {
                InsertCustomerData();
            }

        }
   


        private void AddEditCustForm_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = SaveAllowed();
        }

        public void InsertCustomerData()
        {
            try
            {
                {
                    //finding name of city from drop down
                    string getCity = dropCity.GetItemText(dropCity.Text);
                    
                    //selecting city id based off of city name
                    string sql = "SELECT cityId from city where city = '" + getCity + "';";

                    DataTable cityResult = new DataTable();
                    universals.GetData(sql, cityResult);
                    if (cityResult.Rows.Count > 0)
                    {
                        int cID = Convert.ToInt32(cityResult.Rows[0][0]);
                        DataManager.CityID = cID;
                    }
                    //query to enter address data in address table
                    string insertAddressData =
                        "INSERT INTO address (address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdateBy)" +
                        "VALUES ('" + txtAddress.Text + "', ' ', '" + DataManager.CityID + "', '" + txtZip.Text + "', '"  + txtPhone.Text + "', '"
                         + TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DataManager.CurrentUser + "', '" + DataManager.CurrentUser + "');";

                    //query to get address ID from address table
                    string getAddress = "SELECT addressId FROM address WHERE address = '" + txtAddress.Text + "';";

                    DataTable addressResult = new DataTable();
                    customer.InsertAddress(insertAddressData, getAddress, addressResult);

                    if (addressResult.Rows.Count > 0)
                    {
                        int aID = Convert.ToInt32(addressResult.Rows[0][0]);
                        DataManager.AddressID = aID;
                    }
                    
                    //query to insert customer data into customer table
                    string insertCustData =
                        "INSERT INTO customer (customerName, addressId, active, createDate, createdBy, lastUpdateBy)" +
                        "VALUES ('" + txtName.Text + "', '" + DataManager.AddressID + "', 1 ,'" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "', '" + DataManager.CurrentUser + "', '" + DataManager.CurrentUser + "');";

                    universals.ExecuteNonQueryUpdater(insertCustData);
                    this.Hide();
                    MainForm dash = new MainForm();
                    dash.Show();
                }
            }
            catch (Exception)
            {
                lblError.Text = "An error has occurred. Please try again.";
            }
        }

        public void UpdateCustomerData()
        {
            try
            {
                {
                    string updateCity = dropCity.GetItemText(dropCity.SelectedItem);
                    string citySql = "SELECT cityId FROM city WHERE city ='" + updateCity + "';";

                    DataTable cityCombo = new DataTable();
                    universals.GetData(citySql, cityCombo);
                    if (cityCombo.Rows.Count >0)
                    {
                        int id = (int)cityCombo.Rows[0][0];
                        DataManager.CityID = id;
                    }

                    string addressID = "SELECT addressId FROM customer WHERE customerId = '" + DataManager.CustomerID + "';";

                    DataTable addressDt = new DataTable();
                    universals.GetData(addressID, addressDt);
                    if (addressDt.Rows.Count > 0)
                    {
                        int addressid = (int)addressDt.Rows[0][0];
                        DataManager.AddressID = addressid;
                    }
                    string addressUpdate =
                        "UPDATE address SET address = '" + txtAddress.Text + "', postalCode ='"  + txtZip.Text + "', phone ='" + txtPhone.Text + "', cityId ='" + DataManager.CityID + "', " +
                        "lastUpdate = '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "',  " +
                        "lastUpdateBy = '" + DataManager.CurrentUser + "' " +
                        "WHERE addressId = '" + DataManager.AddressID + "';";

                    string customerUpdate = "UPDATE customer SET customerName = '" + txtName.Text + "', " + "lastUpdate = '" +
                        TimeZoneInfo.ConvertTimeToUtc(DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss") + "',  " +
                        "lastUpdateBy = '" + DataManager.CurrentUser + "' " +
                        "WHERE customerId = '" + DataManager.CustomerID + "';";

                    universals.ExecuteNonQueryUpdater(addressUpdate);
                    universals.ExecuteNonQueryUpdater(customerUpdate);
                    this.Hide();
                    MainForm dash = new MainForm();
                    dash.Show();
                }
            }
            catch (Exception)
            {
                lblError.Text = "An error has occurred. Please try again.";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            bool validAddress = universals.IsNotNullOrEmpty(txtAddress.Text);
            universals.ValidateField(txtAddress, validAddress);
            btnSave.Enabled = SaveAllowed();
        }

        private void txtZip_TextChanged(object sender, EventArgs e)
        {
            bool zipFormat = universals.CheckZipFormat(txtZip.Text.ToString());
            bool validZip = universals.IsNotNullOrEmpty(txtZip.Text);
            universals.ValidateField(txtZip, validZip);
            universals.ValidateField(txtZip, zipFormat);
            btnSave.Enabled = SaveAllowed();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            bool format = universals.CheckPhoneFormat(txtPhone.Text.ToString());
            bool validPhone = universals.IsNotNullOrEmpty(txtPhone.Text);
            universals.ValidateField(txtPhone, validPhone);
            universals.ValidateField(txtPhone, format);
            if (txtPhone.BackColor.Equals(System.Drawing.Color.Yellow))
            {
                lblError.Text = "Please enter phone as ###-####";
                btnSave.Enabled = false;
            }
            else if (txtPhone.BackColor.Equals(System.Drawing.Color.White))
            {
                lblError.Text = "";
                btnSave.Enabled = true;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            bool validName = universals.IsNotNullOrEmpty(txtName.Text);
            universals.ValidateField(txtName, validName);
            btnSave.Enabled = SaveAllowed();
        }
    }
}
