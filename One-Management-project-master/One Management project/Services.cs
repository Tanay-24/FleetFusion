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
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void btnRailway_Click(object sender, EventArgs e)
        {
            this.Hide();
            Railway_Register railway_Register = new Railway_Register();
            railway_Register.ShowDialog();
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ship_Register ship_Register = new Ship_Register();
            ship_Register.ShowDialog();
        }

        private void btnAirline_Click(object sender, EventArgs e)
        {
            this.Hide();
            Airline_Register airline_Register = new Airline_Register();
            airline_Register.ShowDialog();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bus_Register bus_Register = new Bus_Register();
            bus_Register.ShowDialog();
        }

        private void btnGoods_Click(object sender, EventArgs e)
        {
            this.Hide();
            Goods_Register goods_Register = new Goods_Register();
            goods_Register.ShowDialog();
        }
    }
}
