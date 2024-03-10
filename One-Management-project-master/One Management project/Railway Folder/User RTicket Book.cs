using MySql.Data.MySqlClient;
using One_Management_project.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Management_project.Railway_Folder
{
    public partial class User_RTicket_Book : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        
        public User_RTicket_Book()
        {
            InitializeComponent();
            
        }

        private void User_RTicket_Book_Load(object sender, EventArgs e)
        {
            string sqlqurytrainname = "Select * from transportadd.trainadd";
            MySqlCommand cmd = new MySqlCommand(sqlqurytrainname, conn);
            conn.Open();
            MySqlDataAdapter sdr = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            cbTrainnameandnumber.DataSource = dt;
            cbTrainnameandnumber.DisplayMember = "TrainNumberAndName";
            conn.Close();

          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassengername.Text = "";
            cbSource.Text = "";
            cbDestination.Text = "";
            txtNoofseats.Text = "";
            label12.Text = "";
            dateTimePicker1.Text = "";
            cbGender.Text = "";
            cbPassenegerage.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassengername.Text == "" || txtNoofseats.Text == "" || cbSource.SelectedItem.ToString() == "" || cbDestination.SelectedItem.ToString() == "" || label12.Text == "" || cbPassenegerage.SelectedItem.ToString() == "" || cbGender.SelectedItem.ToString() == "" || dateTimePicker1.Value.Date.ToString() == "" || cbTrainnameandnumber.SelectedItem.ToString() == "" || txtUsermobile.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                conn.Open();
                string iquery = "INSERT INTO ptickets.prtickets(`ID`,`PassengerName`,`PassengerAge`,`Gender`,`NoOfSeats`,`Source`,`Destination`,`JourneyDate`,`TicketCost`,`UserMobile`,`TrainNameandNumber`) VALUES (NULL, '" + txtPassengername.Text + "', '" + cbPassenegerage.SelectedItem.ToString() + "', '" + cbGender.SelectedItem.ToString() + "', '" + txtNoofseats.Text + "','" + cbSource.SelectedItem.ToString() + "','" + cbDestination.SelectedItem.ToString() + "', '" + dateTimePicker1.Value.Date.ToString() + "','" + label12.Text + "','"+ txtUsermobile.Text +"','"+ cbTrainnameandnumber.SelectedItem.ToString() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                commandDatabase.CommandTimeout = 180;
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Ticket Added Successfully!");
                conn.Close();
                this.Hide();
                //PrintDialog printDialog = new PrintDialog();
                //printDialog.ShowDialog();
            }

        }


        private void cbTrainnameandnumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Railway user_Railway = new User_Railway();
            user_Railway.ShowDialog();
        }


        private void cbSource_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap,-10,0);   
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (cbSource.SelectedIndex == 0 && cbDestination.SelectedIndex == 1 || cbSource.SelectedIndex == 1 && cbDestination.SelectedIndex == 0)
            {
                MessageBox.Show("Total Cost is 450");
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
    }
}
