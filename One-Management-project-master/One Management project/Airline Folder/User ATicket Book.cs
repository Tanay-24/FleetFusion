using MySql.Data.MySqlClient;
using One_Management_project.Bus_Folder;
using One_Management_project.Railway_Folder;
using One_Management_project.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Management_project.Airline_Folder
{
    public partial class User_ATicket_Book : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public User_ATicket_Book()
        {
            InitializeComponent();
        }

        private void User_ATicket_Book_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassengername.Text == "" || txtNoofseats.Text == "" || cbSource.SelectedItem.ToString() == "" || cbDestination.SelectedItem.ToString() == "" || label9.Text == "" || cbPassenegerage.SelectedItem.ToString() == "" || cbGender.SelectedItem.ToString() == "" || dateTimePicker1.Value.Date.ToString() == "" || txtUsermobile.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                conn.Open();
                string iquery = "INSERT INTO ptickets.patickets(`ID`,`PassengerName`,`PassengerAge`,`Gender`,`NoOfSeats`,`Source`,`Destination`,`JourneyDate`,`TicketCost`,`UserMobile`) VALUES (NULL, '" + txtPassengername.Text + "', '" + cbPassenegerage.SelectedItem.ToString() + "', '" + cbGender.SelectedItem.ToString() + "', '" + txtNoofseats.Text + "','" + cbSource.SelectedItem.ToString() + "','" + cbDestination.SelectedItem.ToString() + "', '" + dateTimePicker1.Value.Date.ToString() + "','" + label9.Text + "','" + txtUsermobile.Text + "')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                commandDatabase.CommandTimeout = 180;
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Ticket Added Successfully!");
                conn.Close();
                this.Hide();
                User_Flight user_Flight = new User_Flight();
                user_Flight.ShowDialog();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengername.Text = "";
            cbSource.Text = "";
            cbDestination.Text = "";
            txtNoofseats.Text = "";
            label9.Text = "";
            dateTimePicker1.Text = "";
            cbGender.Text = "";
            cbPassenegerage.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Flight user_Flight = new User_Flight();
            user_Flight.ShowDialog();
        }

        private void txtTotalcost_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void label9_Click(object sender, EventArgs e)
        {
            if (cbSource.SelectedIndex == 0 && cbDestination.SelectedIndex == 1 || cbSource.SelectedIndex == 1 && cbDestination.SelectedIndex == 0)
            {
                MessageBox.Show("Total Cost is 330");
            }
            else if (cbSource.SelectedIndex == 0 && cbDestination.SelectedIndex == 2 || cbSource.SelectedIndex == 2 && cbDestination.SelectedIndex == 0)
            {
                MessageBox.Show("Total Cost is 330");
            }
            else
            {
                MessageBox.Show("Total Cost is 120");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, -10, 0);
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {

            Graphics graphics = this.CreateGraphics();
            bitmap = new Bitmap(this.Size.Width, this.Size.Height, graphics);
            Graphics g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(this.Location.X, this.Location.Y, -10, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }
    }
}
