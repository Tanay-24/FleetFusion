using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace One_Management_project
{
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand cmd;
        MySqlDataReader reader;
        private const int MaxLoginAttempts = 3;
        private const int LockoutDurationSeconds = 60; // 1 minute lockout duration
        private DateTime lockoutEndTime;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
                return;
            }

            if (DateTime.Now < lockoutEndTime)
            {
                MessageBox.Show("Too many failed attempts. Please try again after 1min.");
                return;
            }

            conn.Open();
            string selectQuery = "SELECT * FROM loginform.userinfo WHERE Username = '" + txtUName.Text + "' AND Password = '" + txtPassword.Text + "';";
            cmd = new MySqlCommand(selectQuery, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                string Query = "update loginform.userinfo set LastLogin='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where Username='" + this.txtUName.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MyConn2.Close();

                MessageBox.Show("Login Successful!");
                ResetLoginAttempts();
                this.Hide();
                Services services = new Services();
                services.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect Login Information! Try again.");
                IncrementLoginAttempts();
                if (loginAttempts >= MaxLoginAttempts)
                {
                    lockoutEndTime = DateTime.Now.AddSeconds(LockoutDurationSeconds);
                }
            }

            conn.Close();
        }

        private void btnCreateanaccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUName_TextChanged(object sender, EventArgs e)
        {

        }

        private int loginAttempts = 0;

        private void IncrementLoginAttempts()
        {
            loginAttempts++;
        }

        private void ResetLoginAttempts()
        {
            loginAttempts = 0;
        }
    }
}
