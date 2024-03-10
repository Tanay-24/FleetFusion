using MySql.Data.MySqlClient;
using One_Management_project.Railway_Folder;
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
    public partial class Railway_Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Railway_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtRailwayUName.Text) || string.IsNullOrEmpty(txtRailwayEmail.Text))
            {
                MessageBox.Show("Please input Name and Email", "Error");
            }

            else
            {
                conn.Open();
                string selectQuery = "SELECT * FROM loginform.rcompanyinfo WHERE Name = '" + txtRailwayUName.Text + "' AND Email = '" + txtRailwayEmail.Text + "';";
                cmd = new MySqlCommand(selectQuery, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.rcompanyinfo set LastLogin='" + dateTimePicker1.Value + "' where Name='" + this.txtRailwayUName.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Home_Page home_Page = new Home_Page();
                    home_Page.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRailwaycreateaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Railway_Register railway_Register = new Railway_Register();
            railway_Register.ShowDialog();
        }

        private void txtRailwayPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Railway_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
