using MySql.Data.MySqlClient;
using ScheduleProgram.Universal;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace ScheduleProgram
{
    public partial class Login : Form
    {
        public delegate string Hello(string userName);
        private static DataManager dataManager = new DataManager();
        
           
        public Login()
        {
            InitializeComponent();
            ShowLocalLanguage();

        }
    
        private void ShowLocalLanguage()
        {
            if (CultureInfo.CurrentCulture.Name == "da-DK")
            {

                showDanish();
            }
            else
            {
                
                showEnglish();
            }
                   
                
         }
        

        private void showEnglish()
        {
            lblLogin.Text = "Login";
            lblUsername.Text = "Username";
            lblPassword.Text = "Password";
            btnSignIn.Text = "Sign In";
            btnExit.Text = "Exit";
           
        }

        private void showDanish()
        {
            lblLogin.Text = "Log på";
            lblUsername.Text = "Brugernavn";
            lblPassword.Text = "Adgangskode";
            btnSignIn.Text = "Log ind";
            btnExit.Text = "Afslut";
           
        }
        private void SignInForm_Load(object sender, EventArgs e)
        {
            
        }

       
        private void WriteLogin()
        {
            try
            {
                
                if (File.Exists("LoginRecord.txt"))
                {
                    using (StreamWriter e = File.AppendText("LoginRecord.txt"))
                    {
                        e.WriteLine(txtUsername.Text + " successfully logged in at " + DateTime.Now.ToString(), e);
                    }
                }
                
                else
                {
                    using (StreamWriter logUser = new StreamWriter("LoginRecord.txt"))
                    {
                        logUser.WriteLine(txtUsername.Text + " successfully logged in at " + DateTime.Now.ToString());
                    }
                }          
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Write to file exception.");
            }
        }

        private void CheckAppt()
        {
            DateTime Current = Convert.ToDateTime(DateTime.UtcNow);
            DateTime Future = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);

            string upcomingAppoinments = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.start, appointment.end from appointment INNER JOIN customer on appointment.customerId = customer.customerId where start BETWEEN '" +
                Current.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" +
                Future.ToString("yyyy-MM-dd HH:mm:ss") + "';";
            DataTable upcoming = new DataTable();
            dataManager.TableReader(upcomingAppoinments, upcoming);

            if (upcoming.Rows.Count > 0)
            {
                for (int i = 0; i < upcoming.Rows.Count; i++)
                {
                    MessageBox.Show("You have an appointment with " + upcoming.Rows[i]["customerName"] + " in 15 minutes.", "Important!");
                }
            }
        }

        private void lblSignin_Click(object sender, EventArgs e)
        {
            
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connect = new MySqlConnection(DBConnector.ConnectionString))
            {
                string selectUser = "Select * From user where userName = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                DataTable dataTableLogin = new DataTable();
                dataManager.GetData(selectUser, dataTableLogin);
                if (dataTableLogin.Rows.Count > 0)
                {
                    //Confirms login was successful. Lambda used to shorten overall syntax
                    Hello obj = (currentUserName) => { return currentUserName + ", you have successfully logged into the scheduling system"; };
                    string Hello = obj.Invoke(DataManager.CurrentUser);
                    MessageBox.Show(Hello);
                    WriteLogin();
                    CheckAppt();

                    this.Hide();
                    MainForm dash = new MainForm();
                    dash.Show();
                }
                else
                {
                    if (CultureInfo.CurrentCulture.Name == "da-DK") //FIX THIS DAN YOU DUMMY
                    {

                        MessageBox.Show("Brugernavnet eller adgangskoden blev ikke fundet.");
                  

                    }
                    else
                    {
                        MessageBox.Show("The username or password was not found.");
                        
                    }
                }
            }
            dataManager.GetCurrentUserName();
            dataManager.GetCurrentUserID();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }


    }

       
    
}
