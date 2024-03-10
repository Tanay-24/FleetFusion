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

namespace One_Management_project.User
{
    public partial class URegister : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306;username=root;password=");
        public URegister()
        {
            InitializeComponent();
        }

        private void btnGobacktologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ULogin1 uLogin1 = new ULogin1();
            uLogin1.ShowDialog();
        }

        private void URegister_Load(object sender, EventArgs e)
        {
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Other");
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cbGender.Text)  || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCPassword.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                conn.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.customer WHERE Name = @Name", conn),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.customer WHERE Email = @UserEmail", conn);


                cmd1.Parameters.AddWithValue("@Name", txtName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Name not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {

                    string iquery = "INSERT INTO loginform.customer(`ID`,`Name`,`Gender`,`Email`, `Password`) VALUES (NULL, '" + txtName.Text + "', '" + cbGender.Text + "', '" + txtEmail.Text + "', '" + txtPassword.Text + "')";
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
                Choose_Type choose_Type = new Choose_Type();
                choose_Type.ShowDialog();
            }
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShow.Checked == true)
            {
                txtCPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtCPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
