using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using One_Management_project.Railway_Folder;

namespace One_Management_project
{
    public partial class Add_Trains : Form
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public Add_Trains()
        {
            InitializeComponent();
        }

        private void Add_Trains_Load(object sender, EventArgs e)
        {
            // Populate the CheckedListBox with days of the week
            checkedListBox1.Items.AddRange(new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the selected days from the CheckedListBox
            List<string> selectedDays = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                selectedDays.Add(item.ToString());
            }

            // Convert the list of selected days to a comma-separated string
            string selectedDaysString = string.Join(",", selectedDays);

            // Insert the train data into the database
            conn.Open();
            string iquery = "INSERT INTO transportadd.trainadd(`ID`,`TrainNumberAndName`,`TrainType`,`Source`,`SHour`,`SMinute`,`Destination`,`DHour`,`DMinute`,`NoOfCoches`,`TrainLaunchDate`,`NoOfDaysRunning`) VALUES (NULL, @TrainNumberAndName, @TrainType, @Source, @SHour, @SMinute, @Destination, @DHour, @DMinute, @Noofcoches, @TrainLaunchDate, @NoOfDaysRunning)";
            MySqlCommand commandDatabase = new MySqlCommand(iquery, conn);
            commandDatabase.Parameters.AddWithValue("@TrainNumberAndName", txtTrainnumberandname.Text);
            commandDatabase.Parameters.AddWithValue("@TrainType", cbTraintype.SelectedItem?.ToString() ?? "");
            commandDatabase.Parameters.AddWithValue("@Source", cbSource.SelectedItem?.ToString() ?? "");
            commandDatabase.Parameters.AddWithValue("@SHour", cbSoureHour.SelectedItem?.ToString() ?? "");
            commandDatabase.Parameters.AddWithValue("@SMinute", cbSourceMinute.SelectedItem?.ToString() ?? "");
            commandDatabase.Parameters.AddWithValue("@Destination", cbDestination.SelectedItem?.ToString() ?? "");
            commandDatabase.Parameters.AddWithValue("@DHour", cbDestinationHour.SelectedItem?.ToString() ?? "");
            commandDatabase.Parameters.AddWithValue("@DMinute", cbDestinationMinute.SelectedItem?.ToString() ?? "");
            commandDatabase.Parameters.AddWithValue("@NoOfCoches", txtNoofcoches.Text);
            commandDatabase.Parameters.AddWithValue("@TrainLaunchDate", dateTimePicker1.Value.Date.ToString());
            commandDatabase.Parameters.AddWithValue("@NoOfDaysRunning", selectedDaysString);

            commandDatabase.ExecuteNonQuery();
            MessageBox.Show("Train Added Successfully!");
            conn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtTrainnumberandname.Text = cbTraintype.Text = cbSource.Text = cbSoureHour.Text = cbSourceMinute.Text = cbDestination.Text = cbDestinationHour.Text = cbDestinationMinute.Text = txtNoofcoches.Text = "";
            dateTimePicker1.Value = DateTime.Now;

            // Uncheck all items in the CheckedListBox
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
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
