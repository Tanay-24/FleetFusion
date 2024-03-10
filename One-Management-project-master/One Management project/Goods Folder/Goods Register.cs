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
    public partial class Goods_Register : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        //MySqlCommand cmd;
        //MySqlDataReader reader;
        public Goods_Register()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Goods_Login goods_Login = new Goods_Login();
            goods_Login.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!this.txtGoodsEmail.Text.Contains('@') || !this.txtGoodsEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtGoodsUName.Text) || string.IsNullOrEmpty(txtGoodsCompanyName.Text) || string.IsNullOrEmpty(txtGoodsEmail.Text) || string.IsNullOrEmpty(txtGoodsPhone.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.gcompanyinfo WHERE Name = @UserName", conn),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.gcompanyinfo WHERE Email = @UserEmail", conn);


                cmd1.Parameters.AddWithValue("@UserName", txtGoodsUName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtGoodsEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Name not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.gcompanyinfo(`ID`,`Name`,`CompanyName`,`Email`, `Phone`) VALUES (NULL, '" + txtGoodsUName.Text + "', '" + txtGoodsCompanyName.Text + "', '" + txtGoodsEmail.Text + "', '" + txtGoodsPhone.Text + "')";
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
