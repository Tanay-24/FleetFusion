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

namespace One_Management_project.Goods_Folder
{
    public partial class GoodsAndTransport : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public GoodsAndTransport()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVehicleNumber.Text = "";
            cbVehicletype.Text = "";
            txtSource.Text = "";
            txtDestination.Text = "";
            cbStatedestination.Text = "";
            cbStatesource.Text = "";
            dateTimePicker1.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtVehicleNumber.Text == "" || cbVehicletype.SelectedItem.ToString() == "" || txtSource.Text == "" || txtDestination.Text == "" || cbStatesource.SelectedItem.ToString() == "" || cbStatedestination.SelectedItem.ToString() == "" || dateTimePicker1.Value.Date.ToString() == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                conn.Open();
                string iquery = "INSERT INTO transportadd.goodsadd(`ID`,`VehicleNumber`,`VehicleType`,`Source`,`Destination`,`StateSource`,`StateDestination`,`VehicleRollOutDate`) VALUES (NULL, '" + txtVehicleNumber.Text + "', '" + cbVehicletype.SelectedItem.ToString() + "', '" + txtSource.Text + "', '" + txtDestination.Text + "','" + cbStatesource.SelectedItem.ToString() + "', '" + cbStatedestination.SelectedItem.ToString() + "', '" + dateTimePicker1.Value.Date.ToString() + "')";
                MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
                commandDatabase.CommandTimeout = 180;
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Goods or Other Transport Vehicle Added Successfully!");
                conn.Close();
                this.Hide();
                Services services = new Services();
                services.ShowDialog();
            }
        }
    }
}
