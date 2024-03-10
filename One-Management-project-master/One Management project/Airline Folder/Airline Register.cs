using MySql.Data.MySqlClient;
using One_Management_project.Airline_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Management_project
{
    public partial class Airline_Register : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        //MySqlCommand cmd;
        //MySqlDataReader reader;
        public Airline_Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!this.txtAirlineEmail.Text.Contains('@') || !this.txtAirlineEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtAirlineUName.Text) || string.IsNullOrEmpty(txtAirlineCompanyName.Text) || string.IsNullOrEmpty(txtAirlineEmail.Text) || string.IsNullOrEmpty(txtAirlinePhone.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.acompanyinfo WHERE Name = @UserName", conn),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.acompanyinfo WHERE Email = @UserEmail", conn);


                cmd1.Parameters.AddWithValue("@UserName", txtAirlineUName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtAirlineEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Name not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.acompanyinfo(`ID`,`Name`,`CompanyName`,`Email`, `Phone`) VALUES (NULL, '" + txtAirlineUName.Text + "', '" + txtAirlineCompanyName.Text + "', '" + txtAirlineEmail.Text + "', '" + txtAirlinePhone.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Account Successfully Created!");

                }

                conn.Close();
                this.Hide();
                Flight_Add flight_Add = new Flight_Add();
                flight_Add.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Airline_Login airline_Login = new Airline_Login();
            airline_Login.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }
    }
}
