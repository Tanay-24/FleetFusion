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
using MySql.Data.MySqlClient;
using One_Management_project.Railway_Folder;

namespace One_Management_project
{
    public partial class Add_Trains : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        //MySqlCommand cmd;
        //MySqlDataReader reader;
        public Add_Trains()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTrainnumberandname.Text = "";
            cbTraintype.Text = "";
            cbSource.Text = "";
            cbSoureHour.Text = "";
            cbSourceMinute.Text = "";
            cbDestination.Text = "";
            cbDestinationHour.Text = "";
            cbDestinationMinute.Text = "";
            txtNoofcoches.Text = "";
            dateTimePicker1.Text = "";
            cbNoofdaysrunning.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtTrainnumberandname.Text == "" || txtNoofcoches.Text == "" || cbSource.SelectedItem.ToString() == "" || cbDestination.SelectedItem.ToString() == "" || dateTimePicker1.Value.Date.ToString() == "" || cbNoofdaysrunning.SelectedItem.ToString() == "" || cbSoureHour.SelectedItem.ToString() == "" || cbSourceMinute.SelectedItem.ToString() == "" || cbDestinationHour.SelectedItem.ToString() == "" || cbDestinationMinute.SelectedItem.ToString() == "") 
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                    conn.Open();
                    string iquery = "INSERT INTO transportadd.trainadd(`ID`,`TrainNumberAndName`,`TrainType`,`Source`,`SHour`,`SMinute`,`Destination`,`DHour`,`DMinute`,`No.OfCoches`,`TrainLaunchDate`,`NoOfDaysRunning`) VALUES (NULL, '" + txtTrainnumberandname.Text + "', '" + cbTraintype.SelectedItem.ToString() + "', '" + cbSource.SelectedItem.ToString() + "', '" + cbSoureHour.SelectedItem.ToString() + "','" + cbSourceMinute.SelectedItem.ToString() + "','" + cbDestination.SelectedItem.ToString() + "','" + cbDestinationHour.SelectedItem.ToString() + "','" + cbDestinationMinute.SelectedItem.ToString() + "','" + txtNoofcoches.Text + "', '" + dateTimePicker1.Value.Date.ToString() + "','" + cbNoofdaysrunning.SelectedItem.ToString() + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                    commandDatabase.CommandTimeout = 180;
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    MessageBox.Show("Train Added Successfully!");
                    conn.Close();
            }
            //conn.Close();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Page home_Page = new Home_Page();
            home_Page.ShowDialog();
        }

        private void Add_Trains_Load(object sender, EventArgs e)
        {

        }
    }
}
