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

namespace One_Management_project.User
{
    public partial class ULogin1 : Form
    {

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader reader;
        public ULogin1()
        {
            InitializeComponent();
        }

        private void ULogin1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Name and Password", "Error");
            }

            else
            {
                conn.Open();
                string selectQuery = "SELECT * FROM loginform.customer WHERE Name = '" + txtName.Text + "' AND Password = '" + txtPassword.Text + "';";
                cmd = new MySqlCommand(selectQuery, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.customer set LastLogin='" + dateTimePicker1.Value + "' where Name='" + this.txtName.Text + "';";
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
                    Choose_Type choose_Type = new Choose_Type();
                    choose_Type.ShowDialog();

                }
                else
                {

                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                conn.Close();
            }
        }

        private void btnCreateanaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            URegister uRegister = new URegister();
            uRegister.ShowDialog();
        }
    }
}
