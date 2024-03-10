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
    public partial class Airline_Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader reader;
        public Airline_Login()
        {
            InitializeComponent();
        }

        private void btnAirlinecreateaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Airline_Register airline_Register = new Airline_Register();
            airline_Register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuery = "SELECT * FROM loginform.acompanyinfo WHERE Name = '" + txtAirlineUName.Text + "' AND Email = '" + txtAirlineEmail.Text + "';";
            cmd = new MySqlCommand(selectQuery, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                string Query = "update loginform.acompanyinfo set LastLogin='" + dateTimePicker1.Value + "' where Name='" + this.txtAirlineUName.Text + "';";
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
                Airline_Home_page airline_Home_page = new Airline_Home_page();  
                airline_Home_page.ShowDialog();

            }
            else
            {

                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            conn.Close();
        }
    }
}
