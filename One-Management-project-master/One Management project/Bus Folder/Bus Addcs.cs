using MySql.Data.MySqlClient;
using One_Management_project.Bus_Folder;
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
    public partial class Bus_Addcs : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public Bus_Addcs()
        {
            InitializeComponent();
        }

        private void Bus_Addcs_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBusNumber.Text = "";
            cbBustype.Text = "";
            cbSource.Text = "";
            cbSoureHour.Text = "";
            cbSourceMinute.Text = "";
            cbDestination.Text = "";
            cbDestinationHour.Text = "";
            cbDestinationMinute.Text = "";
            dateTimePicker1.Text = "";
            cbNoofdaysrunning.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtBusNumber.Text == "" || cbBustype.Text == "" || cbSource.Text == "" || cbDestination.Text == "" || dateTimePicker1.Value.Date.ToString() == "" || cbSoureHour.SelectedItem.ToString() == "" || cbSourceMinute.SelectedItem.ToString() == "" || cbDestinationHour.SelectedItem.ToString() == "" || cbDestinationMinute.SelectedItem.ToString() == "" || cbNoofdaysrunning.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                conn.Open();
                string iquery = "INSERT INTO transportadd.busadd(`ID`,`BusNumber`,`BusType`,`Source`,`SHour`,`SMinute`,`Destination`,`DHour`,`DMinute`,`NoOfDaysRunning`,`BusLunchDate`) VALUES (NULL, '" + txtBusNumber.Text + "', '" + cbBustype.SelectedItem.ToString() + "', '" + cbSource.SelectedItem.ToString() + "','" + cbSoureHour.SelectedItem.ToString() + "','" + cbSourceMinute.SelectedItem.ToString() + "', '" + cbDestination.SelectedItem.ToString() + "','" + cbDestinationHour.SelectedItem.ToString() + "','" + cbDestinationMinute.SelectedItem.ToString() + "','" + cbNoofdaysrunning.SelectedItem.ToString() + "', '" + dateTimePicker1.Value.Date.ToString() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                commandDatabase.CommandTimeout = 180;
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Bus Added Successfully!");
                conn.Close();
                //this.Hide();
                //Services services = new Services();
                //services.ShowDialog();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Page home_Page = new Home_Page();
            home_Page.ShowDialog();
        }
    }
}
