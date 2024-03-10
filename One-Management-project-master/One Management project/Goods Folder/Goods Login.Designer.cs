namespace One_Management_project
{
    partial class Goods_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Goods_Login));
            this.btnGoodscreateaccount = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtGoodsEmail = new System.Windows.Forms.TextBox();
            this.txtGoodsUName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoodscreateaccount
            // 
            this.btnGoodscreateaccount.BackColor = System.Drawing.Color.Snow;
            this.btnGoodscreateaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnGoodscreateaccount.Location = new System.Drawing.Point(487, 367);
            this.btnGoodscreateaccount.Name = "btnGoodscreateaccount";
            this.btnGoodscreateaccount.Size = new System.Drawing.Size(187, 46);
            this.btnGoodscreateaccount.TabIndex = 31;
            this.btnGoodscreateaccount.Text = "Create Account";
            this.btnGoodscreateaccount.UseVisualStyleBackColor = false;
            this.btnGoodscreateaccount.Click += new System.EventHandler(this.btnGoodscreateaccount_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(469, 38);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(288, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 123);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Snow;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnLogin.Location = new System.Drawing.Point(307, 367);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 46);
            this.btnLogin.TabIndex = 28;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtGoodsEmail
            // 
            this.txtGoodsEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtGoodsEmail.Location = new System.Drawing.Point(274, 294);
            this.txtGoodsEmail.MaxLength = 100;
            this.txtGoodsEmail.Name = "txtGoodsEmail";
            this.txtGoodsEmail.Size = new System.Drawing.Size(273, 29);
            this.txtGoodsEmail.TabIndex = 24;
            // 
            // txtGoodsUName
            // 
            this.txtGoodsUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtGoodsUName.Location = new System.Drawing.Point(274, 227);
            this.txtGoodsUName.Name = "txtGoodsUName";
            this.txtGoodsUName.Size = new System.Drawing.Size(273, 29);
            this.txtGoodsUName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(143, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // Goods_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoodscreateaccount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtGoodsEmail);
            this.Controls.Add(this.txtGoodsUName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Goods_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods_Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoodscreateaccount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtGoodsEmail;
        private System.Windows.Forms.TextBox txtGoodsUName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}