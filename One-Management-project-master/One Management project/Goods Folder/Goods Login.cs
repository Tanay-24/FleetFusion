using MySql.Data.MySqlClient;
using One_Management_project.Goods_Folder;
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
    public partial class Goods_Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader reader;
        public Goods_Login()
        {
            InitializeComponent();
        }

        private void btnGoodscreateaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Goods_Register goods_Register = new Goods_Register();
            goods_Register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGoodsUName.Text) || string.IsNullOrEmpty(txtGoodsEmail.Text))
            {
                MessageBox.Show("Please input Name and Email", "Error");
            }

            else
            {
                conn.Open();
                string selectQuery = "SELECT * FROM loginform.gcompanyinfo WHERE Name = '" + txtGoodsUName.Text + "' AND Email = '" + txtGoodsEmail.Text + "';";
                cmd = new MySqlCommand(selectQuery, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.gcompanyinfo set LastLogin='" + dateTimePicker1.Value + "' where Name='" + this.txtGoodsUName.Text + "';";
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
}
