namespace One_Management_project
{
    partial class Ship_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ship_Login));
            this.btnShipcreateaccount = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtShipEmail = new System.Windows.Forms.TextBox();
            this.txtShipUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShipcreateaccount
            // 
            this.btnShipcreateaccount.BackColor = System.Drawing.Color.Snow;
            this.btnShipcreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnShipcreateaccount.Location = new System.Drawing.Point(507, 367);
            this.btnShipcreateaccount.Name = "btnShipcreateaccount";
            this.btnShipcreateaccount.Size = new System.Drawing.Size(187, 46);
            this.btnShipcreateaccount.TabIndex = 23;
            this.btnShipcreateaccount.Text = "Create Account";
            this.btnShipcreateaccount.UseVisualStyleBackColor = false;
            this.btnShipcreateaccount.Click += new System.EventHandler(this.btnShipcreateaccount_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(469, 38);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(308, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 123);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Snow;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLogin.Location = new System.Drawing.Point(327, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 46);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtShipEmail
            // 
            this.txtShipEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtShipEmail.Location = new System.Drawing.Point(294, 294);
            this.txtShipEmail.MaxLength = 100;
            this.txtShipEmail.Name = "txtShipEmail";
            this.txtShipEmail.Size = new System.Drawing.Size(273, 29);
            this.txtShipEmail.TabIndex = 16;
            // 
            // txtShipUName
            // 
            this.txtShipUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtShipUName.Location = new System.Drawing.Point(294, 227);
            this.txtShipUName.Name = "txtShipUName";
            this.txtShipUName.Size = new System.Drawing.Size(273, 29);
            this.txtShipUName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(163, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 18;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // Ship_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.btnShipcreateaccount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtShipEmail);
            this.Controls.Add(this.txtShipUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ship_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ship_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShipcreateaccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtShipEmail;
        private System.Windows.Forms.TextBox txtShipUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}