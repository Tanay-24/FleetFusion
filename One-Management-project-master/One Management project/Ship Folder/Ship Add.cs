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

namespace One_Management_project
{
    public partial class Ship_Add : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public Ship_Add()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShipNumber.Text = "";
            cbShiptype.Text = "";
            cbSource.Text = "";
            cbDestination.Text = "";
            dateTimePicker1.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtShipNumber.Text == "" || cbShiptype.Text == "" || cbSource.Text == "" || cbDestination.Text == "" || dateTimePicker1.Value.Date.ToString() == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                conn.Open();
                string iquery = "INSERT INTO transportadd.shipadd(`ID`,`ShipNumber`,`ShipType`,`Source`,`Destination`,`ShipLaunchDate`) VALUES (NULL, '" + txtShipNumber.Text + "', '" + cbShiptype.SelectedItem.ToString() + "', '" + cbSource.SelectedItem.ToString() + "', '" + cbDestination.SelectedItem.ToString() + "', '" + dateTimePicker1.Value.Date.ToString() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                commandDatabase.CommandTimeout = 180;
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Ship Added Successfully!");
                conn.Close();
                this.Hide();
                Services services = new Services();
                services.ShowDialog();
            }
        }
    }
}
