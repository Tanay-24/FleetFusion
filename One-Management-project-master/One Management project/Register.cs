using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace One_Management_project
{
    public partial class Register : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            cbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        private void btnGobacktologin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void cbShow_CheckedChanged(object sender, EventArgs e)
        {
            txtCPassword.UseSystemPasswordChar = !cbShow.Checked;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string selectQueryUsername = "SELECT * FROM loginform.userinfo WHERE Username = @UserName";
                string selectQueryEmail = "SELECT * FROM loginform.userinfo WHERE Email = @UserEmail";

                MySqlCommand cmd1 = new MySqlCommand(selectQueryUsername, conn);
                MySqlCommand cmd2 = new MySqlCommand(selectQueryEmail, conn);

                cmd1.Parameters.AddWithValue("@UserName", txtUName.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                {
                    userExists = dr1.HasRows;
                }

                using (var dr2 = cmd2.ExecuteReader())
                {
                    mailExists = dr2.HasRows;
                }

                if (userExists)
                {
                    MessageBox.Show("Username not available!");
                    return;
                }

                if (mailExists)
                {
                    MessageBox.Show("Email not available!");
                    return;
                }

                string iquery = "INSERT INTO loginform.userinfo(`ID`,`Name`,`Gender`,`Username`,`Email`, `Password`) VALUES (NULL, @Name, @Gender, @Username, @Email, @Password)";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                commandDatabase.Parameters.AddWithValue("@Name", txtName.Text);
                commandDatabase.Parameters.AddWithValue("@Gender", cbGender.Text);
                commandDatabase.Parameters.AddWithValue("@Username", txtUName.Text);
                commandDatabase.Parameters.AddWithValue("@Email", txtEmail.Text);
                commandDatabase.Parameters.AddWithValue("@Password", txtPassword.Text);

                commandDatabase.ExecuteNonQuery();
                MessageBox.Show("Account Successfully Created!");

                // Send registration email
                SendRegistrationEmail(txtEmail.Text, txtUName.Text, txtPassword.Text);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void SendRegistrationEmail(string userEmail, string username, string password)
        {
            try
            {
                string smtpHost = "smtp.office365.com";
                int smtpPort = 587;
                string smtpUsername = "tanay.puranik2002@gmail.com";
                string smtpPassword = "Tanay@241002";

                using (SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);

                    MailMessage mailMessage = new MailMessage(smtpUsername, userEmail, "Registration Successful", $"Thank you for registering!\nUsername: {username}\nPassword: {password}");
                    smtpClient.Send(mailMessage);
                }

                MessageBox.Show("Registration email sent successfully! Please check your spam folder also.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the registration email: " + ex.Message);
            }
        }
    }
}
