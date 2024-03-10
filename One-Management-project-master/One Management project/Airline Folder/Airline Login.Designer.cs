namespace One_Management_project
{
    partial class Airline_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Airline_Login));
            this.btnAirlinecreateaccount = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtAirlineEmail = new System.Windows.Forms.TextBox();
            this.txtAirlineUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAirlinecreateaccount
            // 
            this.btnAirlinecreateaccount.BackColor = System.Drawing.Color.Snow;
            this.btnAirlinecreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAirlinecreateaccount.Location = new System.Drawing.Point(479, 380);
            this.btnAirlinecreateaccount.Name = "btnAirlinecreateaccount";
            this.btnAirlinecreateaccount.Size = new System.Drawing.Size(187, 46);
            this.btnAirlinecreateaccount.TabIndex = 31;
            this.btnAirlinecreateaccount.Text = "Create Account";
            this.btnAirlinecreateaccount.UseVisualStyleBackColor = false;
            this.btnAirlinecreateaccount.Click += new System.EventHandler(this.btnAirlinecreateaccount_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(469, 38);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(280, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 123);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Snow;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLogin.Location = new System.Drawing.Point(299, 380);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 46);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtAirlineEmail
            // 
            this.txtAirlineEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAirlineEmail.Location = new System.Drawing.Point(266, 307);
            this.txtAirlineEmail.MaxLength = 100;
            this.txtAirlineEmail.Name = "txtAirlineEmail";
            this.txtAirlineEmail.Size = new System.Drawing.Size(273, 29);
            this.txtAirlineEmail.TabIndex = 24;
            // 
            // txtAirlineUName
            // 
            this.txtAirlineUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtAirlineUName.Location = new System.Drawing.Point(266, 240);
            this.txtAirlineUName.Name = "txtAirlineUName";
            this.txtAirlineUName.Size = new System.Drawing.Size(273, 29);
            this.txtAirlineUName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(135, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // Airline_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAirlinecreateaccount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtAirlineEmail);
            this.Controls.Add(this.txtAirlineUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Airline_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airline_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAirlinecreateaccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtAirlineEmail;
        private System.Windows.Forms.TextBox txtAirlineUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}