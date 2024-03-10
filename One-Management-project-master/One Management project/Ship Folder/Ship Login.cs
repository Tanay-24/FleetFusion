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

namespace One_Management_project
{
    public partial class Ship_Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader reader;
        public Ship_Login()
        {
            InitializeComponent();
        }

        private void btnShipcreateaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ship_Register ship_Register = new Ship_Register();
            ship_Register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtShipUName.Text) || string.IsNullOrEmpty(txtShipEmail.Text))
            {
                MessageBox.Show("Please input Name and Email", "Error");
            }

            else
            {
                conn.Open();
                string selectQuery = "SELECT * FROM loginform.scompanyinfo WHERE Name = '" + txtShipUName.Text + "' AND Email = '" + txtShipEmail.Text + "';";
                cmd = new MySqlCommand(selectQuery, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.scompanyinfo set LastLogin='" + dateTimePicker1.Value + "' where Name='" + this.txtShipUName.Text + "';";
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
                    Ship_Add ship_Add = new Ship_Add();
                    ship_Add.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                conn.Close();
            }
        }
    }
}
