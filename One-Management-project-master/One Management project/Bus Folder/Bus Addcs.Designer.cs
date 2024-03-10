namespace One_Management_project
{
    partial class Bus_Addcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbSource = new System.Windows.Forms.ComboBox();
            this.cbBustype = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBusNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbDestinationMinute = new System.Windows.Forms.ComboBox();
            this.cbDestinationHour = new System.Windows.Forms.ComboBox();
            this.cbSourceMinute = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSoureHour = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNoofdaysrunning = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDestination
            // 
            this.cbDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Items.AddRange(new object[] {
            "---Select---",
            "Mumbai",
            "Delhi",
            "Jaipur",
            "Ajmere",
            "Bikaner",
            "Varanasi",
            "Merth",
            "Agra",
            "Udaypur",
            "Pune",
            "Nashik",
            "Nagpur",
            "Banglor",
            "Kolapur",
            "Jashi",
            "Kanyakumari"});
            this.cbDestination.Location = new System.Drawing.Point(340, 299);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(402, 32);
            this.cbDestination.TabIndex = 34;
            // 
            // cbSource
            // 
            this.cbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSource.FormattingEnabled = true;
            this.cbSource.Items.AddRange(new object[] {
            "---Select---",
            "Mumbai",
            "Delhi",
            "Jaipur",
            "Ajmere",
            "Bikaner",
            "Varanasi",
            "Merth",
            "Agra",
            "Udaypur",
            "Pune",
            "Nashik",
            "Nagpur",
            "Banglor",
            "Kolapur",
            "Jashi",
            "Kanyakumari"});
            this.cbSource.Location = new System.Drawing.Point(340, 242);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(402, 32);
            this.cbSource.TabIndex = 33;
            // 
            // cbBustype
            // 
            this.cbBustype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbBustype.FormattingEnabled = true;
            this.cbBustype.Items.AddRange(new object[] {
            "---Select---",
            "Goods",
            "Luxury ",
            "Inter-City",
            "2x2 Seater",
            "3x2 Seater",
            "Slepper"});
            this.cbBustype.Location = new System.Drawing.Point(340, 189);
            this.cbBustype.Name = "cbBustype";
            this.cbBustype.Size = new System.Drawing.Size(402, 32);
            this.cbBustype.TabIndex = 32;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(440, 439);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 46);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("MV Boli", 21.75F);
            this.btnSubmit.Location = new System.Drawing.Point(212, 439);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(139, 46);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(340, 359);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(402, 29);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // txtBusNumber
            // 
            this.txtBusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNumber.Location = new System.Drawing.Point(340, 126);
            this.txtBusNumber.Name = "txtBusNumber";
            this.txtBusNumber.Size = new System.Drawing.Size(402, 29);
            this.txtBusNumber.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Bus launch Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(77, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(77, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(77, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Bus Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(77, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Bus Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Add Buses";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Location = new System.Drawing.Point(-1, 510);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 20);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 20);
            this.panel1.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("MV Boli", 21.75F);
            this.btnBack.Location = new System.Drawing.Point(639, 439);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 46);
            this.btnBack.TabIndex = 35;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbDestinationMinute
            // 
            this.cbDestinationMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbDestinationMinute.FormattingEnabled = true;
            this.cbDestinationMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cbDestinationMinute.Location = new System.Drawing.Point(1024, 303);
            this.cbDestinationMinute.Name = "cbDestinationMinute";
            this.cbDestinationMinute.Size = new System.Drawing.Size(110, 32);
            this.cbDestinationMinute.TabIndex = 46;
            // 
            // cbDestinationHour
            // 
            this.cbDestinationHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbDestinationHour.FormattingEnabled = true;
            this.cbDestinationHour.Items.AddRange(new object[] {
            "---Select---",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbDestinationHour.Location = new System.Drawing.Point(874, 301);
            this.cbDestinationHour.Name = "cbDestinationHour";
            this.cbDestinationHour.Size = new System.Drawing.Size(110, 32);
            this.cbDestinationHour.TabIndex = 45;
            // 
            // cbSourceMinute
            // 
            this.cbSourceMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSourceMinute.FormattingEnabled = true;
            this.cbSourceMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60"});
            this.cbSourceMinute.Location = new System.Drawing.Point(1024, 244);
            this.cbSourceMinute.Name = "cbSourceMinute";
            this.cbSourceMinute.Size = new System.Drawing.Size(110, 32);
            this.cbSourceMinute.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label12.Location = new System.Drawing.Point(1032, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 25);
            this.label12.TabIndex = 43;
            this.label12.Text = "Minute";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label11.Location = new System.Drawing.Point(889, 208);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 42;
            this.label11.Text = "Hour";
            // 
            // cbSoureHour
            // 
            this.cbSoureHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbSoureHour.FormattingEnabled = true;
            this.cbSoureHour.Items.AddRange(new object[] {
            "---Select---",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbSoureHour.Location = new System.Drawing.Point(871, 244);
            this.cbSoureHour.Name = "cbSoureHour";
            this.cbSoureHour.Size = new System.Drawing.Size(110, 32);
            this.cbSoureHour.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label10.Location = new System.Drawing.Point(774, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "D.Timing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label9.Location = new System.Drawing.Point(774, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "S.Timing";
            // 
            // cbNoofdaysrunning
            // 
            this.cbNoofdaysrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbNoofdaysrunning.FormattingEnabled = true;
            this.cbNoofdaysrunning.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday",
            "Weekend only",
            "All Days",
            "",
            "Monday wednesday Friday",
            "Monday Tuesday",
            "Tuesday Thursday saturday",
            "Monday Wednesday",
            "Monday Thursday",
            "Monday Friday"});
            this.cbNoofdaysrunning.Location = new System.Drawing.Point(856, 141);
            this.cbNoofdaysrunning.Name = "cbNoofdaysrunning";
            this.cbNoofdaysrunning.Size = new System.Drawing.Size(231, 32);
            this.cbNoofdaysrunning.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F);
            this.label8.Location = new System.Drawing.Point(889, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "No.Days Running";
            // 
            // Bus_Addcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 529);
            this.Controls.Add(this.cbNoofdaysrunning);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbDestinationMinute);
            this.Controls.Add(this.cbDestinationHour);
            this.Controls.Add(this.cbSourceMinute);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbSoureHour);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.cbBustype);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBusNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Bus_Addcs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus_Addcs";
            this.Load += new System.EventHandler(this.Bus_Addcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbSource;
        private System.Windows.Forms.ComboBox cbBustype;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBusNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbDestinationMinute;
        private System.Windows.Forms.ComboBox cbDestinationHour;
        private System.Windows.Forms.ComboBox cbSourceMinute;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbSoureHour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNoofdaysrunning;
        private System.Windows.Forms.Label label8;
    }
}