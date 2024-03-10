using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace One_Management_project
{
    public partial class Ship_Register : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        //MySqlCommand cmd;
        //MySqlDataReader reader;
        public Ship_Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!this.txtShipEmail.Text.Contains('@') || !this.txtShipEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtShipUName.Text) || string.IsNullOrEmpty(txtShipCompanyName.Text) || string.IsNullOrEmpty(txtShipEmail.Text) || string.IsNullOrEmpty(txtShipPhone.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.scompanyinfo WHERE Name = @UserName", conn),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.scompanyinfo WHERE Email = @UserEmail", conn);


                cmd1.Parameters.AddWithValue("@UserName", txtShipUName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtShipEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Name not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.scompanyinfo(`ID`,`Name`,`CompanyName`,`Email`, `Phone`) VALUES (NULL, '" + txtShipUName.Text + "', '" + txtShipCompanyName.Text + "', '" + txtShipEmail.Text + "', '" + txtShipPhone.Text + "')";
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
                Ship_Add ship_Add = new Ship_Add();
                ship_Add.ShowDialog();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ship_Login ship_Login = new Ship_Login();
            ship_Login.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Services services = new Services();
            services.ShowDialog();
        }
    }
}
