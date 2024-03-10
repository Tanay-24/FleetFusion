using MySql.Data.MySqlClient;
using One_Management_project.Railway_Folder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace One_Management_project
{
    public partial class Railway_Register : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;username=root;password=");

        public Railway_Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!this.txtRailwayEmail.Text.Contains('@') || !this.txtRailwayEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(txtRailwayUName.Text) || string.IsNullOrEmpty(txtRailwayCompanyName.Text) ||  string.IsNullOrEmpty(txtRailwayEmail.Text) || string.IsNullOrEmpty(txtRailwayPhone.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.rcompanyinfo WHERE Name = @UserName", conn),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.rcompanyinfo WHERE Phone = @UserPhone", conn);


                cmd1.Parameters.AddWithValue("@UserName", txtRailwayUName.Text);
                cmd2.Parameters.AddWithValue("@UserPhone", txtRailwayPhone.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Phone Number is not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.rcompanyinfo(`ID`,`Name`,`CompanyName`,`Email`, `Phone`) VALUES (NULL, '" + txtRailwayUName.Text + "', '" + txtRailwayCompanyName.Text + "','" + txtRailwayEmail.Text + "', '" + txtRailwayPhone.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                    commandDatabase.CommandTimeout = 180;

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
                Home_Page home_Page = new Home_Page();
                home_Page.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Railway_Login railway_Login = new Railway_Login();
            railway_Login.ShowDialog();
        }

        private void txtRailwayPhone_TextChanged(object sender, EventArgs e)
        {
            //Regex r = new Regex(@"^[0-9]{10}$");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }
    }
}
