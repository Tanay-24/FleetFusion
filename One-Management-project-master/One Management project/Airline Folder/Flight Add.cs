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

namespace One_Management_project.Airline_Folder
{
    public partial class Flight_Add : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public Flight_Add()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFlightNumber.Text = "";
            cbAircrafttype.Text = "";
            cbFlighttype.Text = "";
            cbSource.Text = "";
            cbSoureHour.Text = "";
            cbSourceMinute.Text = "";
            cbDestination.Text = "";
            cbDestinationHour.Text = "";
            cbDestinationMinute.Text = "";
            dateTimePicker1.Text = "";
            cbNoofdaysflying.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFlightNumber.Text == "" || cbAircrafttype.Text == "" || cbFlighttype.Text == "" || cbSource.Text == "" || cbDestination.Text == "" || dateTimePicker1.Value.Date.ToString() == "" || cbSoureHour.SelectedItem.ToString() == "" || cbSourceMinute.SelectedItem.ToString() == "" || cbDestinationHour.SelectedItem.ToString() == "" || cbDestinationMinute.SelectedItem.ToString() == "" ||cbNoofdaysflying.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                conn.Open();
                string iquery = "INSERT INTO transportadd.flightadd(`ID`,`FlightNumber`,`AircraftType`,`FlightType`,`Source`,`SHour`,`SMinute`,`Destination`,`DHour`,`DMinute`,`No.Days Flying`,`FlightLaunchDate`) VALUES (NULL, '" + txtFlightNumber.Text + "', '" + cbAircrafttype.SelectedItem.ToString() + "', '" + cbFlighttype.SelectedItem.ToString() + "','" + cbSource.SelectedItem.ToString() + "','" + cbSoureHour.SelectedItem.ToString() + "','" + cbSourceMinute.SelectedItem.ToString() + "', '" + cbDestination.SelectedItem.ToString() + "','" + cbDestinationHour.SelectedItem.ToString() + "','" + cbDestinationMinute.SelectedItem.ToString() + "', '"+ cbNoofdaysflying.SelectedItem.ToString() + "' , '" + dateTimePicker1.Value.Date.ToString() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                commandDatabase.CommandTimeout = 180;
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Aircraft Added Successfully!");
                conn.Close();
                //this.Hide();
                //Services services = new Services();
                //services.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Airline_Home_page home_Page = new Airline_Home_page();
            home_Page.ShowDialog();
        }

        private void Flight_Add_Load(object sender, EventArgs e)
        {

        }
    }
}
