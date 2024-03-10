namespace One_Management_project
{
    partial class Services
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRailway = new System.Windows.Forms.Button();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnBus = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnAirline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSalmon;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logistics Servies";
            // 
            // btnRailway
            // 
            this.btnRailway.BackColor = System.Drawing.Color.Gold;
            this.btnRailway.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRailway.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnRailway.Location = new System.Drawing.Point(250, 114);
            this.btnRailway.Name = "btnRailway";
            this.btnRailway.Size = new System.Drawing.Size(449, 82);
            this.btnRailway.TabIndex = 1;
            this.btnRailway.Text = "Railway Management";
            this.btnRailway.UseVisualStyleBackColor = false;
            this.btnRailway.Click += new System.EventHandler(this.btnRailway_Click);
            // 
            // btnShip
            // 
            this.btnShip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShip.Font = new System.Drawing.Font("Sitka Display", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShip.ForeColor = System.Drawing.Color.DeepPink;
            this.btnShip.Location = new System.Drawing.Point(250, 214);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(449, 90);
            this.btnShip.TabIndex = 2;
            this.btnShip.Text = "Ship Management";
            this.btnShip.UseVisualStyleBackColor = false;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // btnBus
            // 
            this.btnBus.BackColor = System.Drawing.Color.LightYellow;
            this.btnBus.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBus.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btnBus.Location = new System.Drawing.Point(250, 320);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(449, 90);
            this.btnBus.TabIndex = 3;
            this.btnBus.Text = "Bus Management";
            this.btnBus.UseVisualStyleBackColor = false;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.BackColor = System.Drawing.Color.LightGreen;
            this.btnGoods.Font = new System.Drawing.Font("Sitka Display", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoods.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGoods.Location = new System.Drawing.Point(250, 425);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(449, 85);
            this.btnGoods.TabIndex = 4;
            this.btnGoods.Text = "GoodsTransport ";
            this.btnGoods.UseVisualStyleBackColor = false;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnAirline
            // 
            this.btnAirline.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAirline.Font = new System.Drawing.Font("Sitka Display", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirline.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAirline.Location = new System.Drawing.Point(250, 529);
            this.btnAirline.Name = "btnAirline";
            this.btnAirline.Size = new System.Drawing.Size(449, 88);
            this.btnAirline.TabIndex = 5;
            this.btnAirline.Text = "Airline Managemet";
            this.btnAirline.UseVisualStyleBackColor = false;
            this.btnAirline.Click += new System.EventHandler(this.btnAirline_Click);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(912, 672);
            this.Controls.Add(this.btnAirline);
            this.Controls.Add(this.btnGoods);
            this.Controls.Add(this.btnBus);
            this.Controls.Add(this.btnShip);
            this.Controls.Add(this.btnRailway);
            this.Controls.Add(this.label1);
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRailway;
        private System.Windows.Forms.Button btnShip;
        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnAirline;
    }
}