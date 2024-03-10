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
    public partial class Bus_Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader reader;
        public Bus_Login()
        {
            InitializeComponent();
        }

        private void btnBuscreateaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus_Register bus_Register = new Bus_Register();
            bus_Register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            string selectQuery = "SELECT * FROM loginform.bcompanyinfo WHERE Name = '" + txtBusUName.Text + "' AND Email = '" + txtBusEmail.Text + "';";
            cmd = new MySqlCommand(selectQuery, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                string Query = "update loginform.bcompanyinfo set LastLogin='" + dateTimePicker1.Value + "' where Name='" + this.txtBusUName.Text + "';";
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
}
