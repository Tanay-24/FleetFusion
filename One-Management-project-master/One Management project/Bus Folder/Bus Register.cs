using MySql.Data.MySqlClient;
using One_Management_project.Bus_Folder;
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
    public partial class Bus_Register : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        //MySqlCommand cmd;
        //MySqlDataReader reader;
        public Bus_Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus_Login bus_Login = new Bus_Login();
            bus_Login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!this.txtBusEmail.Text.Contains('@') || !this.txtBusEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtBusUName.Text) || string.IsNullOrEmpty(txtBusCompanyName.Text) || string.IsNullOrEmpty(txtBusEmail.Text) || string.IsNullOrEmpty(txtBusPhone.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.bcompanyinfo WHERE Name = @UserName", conn),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.bcompanyinfo WHERE Email = @UserEmail", conn);


                cmd1.Parameters.AddWithValue("@UserName", txtBusUName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtBusEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Name not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.bcompanyinfo(`ID`,`Name`,`CompanyName`,`Email`, `Phone`) VALUES (NULL, '" + txtBusUName.Text + "', '" + txtBusCompanyName.Text + "', '" + txtBusEmail.Text + "', '" + txtBusPhone.Text + "')";
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
                Home_Page home_Page = new Home_Page();
                home_Page.ShowDialog();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }
    }
}
