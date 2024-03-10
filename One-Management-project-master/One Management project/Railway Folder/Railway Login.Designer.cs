namespace One_Management_project
{
    partial class Railway_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Railway_Login));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtRailwayEmail = new System.Windows.Forms.TextBox();
            this.txtRailwayUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRailwaycreateaccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(469, 38);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 123);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Snow;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLogin.Location = new System.Drawing.Point(294, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 46);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtRailwayEmail
            // 
            this.txtRailwayEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtRailwayEmail.Location = new System.Drawing.Point(261, 294);
            this.txtRailwayEmail.MaxLength = 100;
            this.txtRailwayEmail.Name = "txtRailwayEmail";
            this.txtRailwayEmail.Size = new System.Drawing.Size(273, 29);
            this.txtRailwayEmail.TabIndex = 7;
            this.txtRailwayEmail.TextChanged += new System.EventHandler(this.txtRailwayPhone_TextChanged);
            // 
            // txtRailwayUName
            // 
            this.txtRailwayUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtRailwayUName.Location = new System.Drawing.Point(261, 227);
            this.txtRailwayUName.Name = "txtRailwayUName";
            this.txtRailwayUName.Size = new System.Drawing.Size(273, 29);
            this.txtRailwayUName.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(130, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // btnRailwaycreateaccount
            // 
            this.btnRailwaycreateaccount.BackColor = System.Drawing.Color.Snow;
            this.btnRailwaycreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnRailwaycreateaccount.Location = new System.Drawing.Point(474, 367);
            this.btnRailwaycreateaccount.Name = "btnRailwaycreateaccount";
            this.btnRailwaycreateaccount.Size = new System.Drawing.Size(187, 46);
            this.btnRailwaycreateaccount.TabIndex = 15;
            this.btnRailwaycreateaccount.Text = "Create Account";
            this.btnRailwaycreateaccount.UseVisualStyleBackColor = false;
            this.btnRailwaycreateaccount.Click += new System.EventHandler(this.btnRailwaycreateaccount_Click);
            // 
            // Railway_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.btnRailwaycreateaccount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtRailwayEmail);
            this.Controls.Add(this.txtRailwayUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Railway_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Railway_Login";
            this.Load += new System.EventHandler(this.Railway_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtRailwayEmail;
        private System.Windows.Forms.TextBox txtRailwayUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRailwaycreateaccount;
    }
}