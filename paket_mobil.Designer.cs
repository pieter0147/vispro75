namespace Final_Project_Vispro
{
    partial class paket_mobil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paket_mobil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPackage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(75, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1760, 900);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1571, 810);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 69;
            this.button4.Text = "back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Cyan;
            this.button3.Location = new System.Drawing.Point(658, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(400, 300);
            this.button3.TabIndex = 68;
            this.button3.Text = resources.GetString("button3.Text");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(199, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 300);
            this.button2.TabIndex = 67;
            this.button2.Text = "Basic Wash \r\n  Rp.100.000\r\n\r\n-Pencucian eksterior\r\n-Pengeringan mobil\r\n-pembersih" +
    "an sederhana\r\n  (roda dan ban)\r\n-Waktu pengerjaan 20-30mnt\r\n";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(1117, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 300);
            this.button1.TabIndex = 66;
            this.button1.Text = "Deep Wash:\r\n  Rp.150.000\r\n\r\n-Semua layanan pada basic wash\r\n-Pembersihan menyelur" +
    "uh \r\n-Pembersihan kolong mobil\r\n-Vakum karpet dan kursi\r\n-Waktu pengerjaan 45-60" +
    "mnt\r\n\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.txtPackage);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtDate);
            this.panel2.Controls.Add(this.txtCost);
            this.panel2.Controls.Add(this.txtLicensePlate);
            this.panel2.Location = new System.Drawing.Point(638, 177);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 177);
            this.panel2.TabIndex = 65;
            // 
            // txtPackage
            // 
            this.txtPackage.Location = new System.Drawing.Point(179, 76);
            this.txtPackage.Name = "txtPackage";
            this.txtPackage.Size = new System.Drawing.Size(100, 26);
            this.txtPackage.TabIndex = 62;
            this.txtPackage.Text = "Package";
            this.txtPackage.TextChanged += new System.EventHandler(this.TxtPackage_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 26);
            this.btnSave.TabIndex = 64;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(84, 34);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(272, 26);
            this.txtDate.TabIndex = 55;
            this.txtDate.ValueChanged += new System.EventHandler(this.TxtDate_ValueChanged);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(301, 76);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 26);
            this.txtCost.TabIndex = 63;
            this.txtCost.Text = "Cost";
            this.txtCost.TextChanged += new System.EventHandler(this.TxtCost_TextChanged);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(54, 76);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(100, 26);
            this.txtLicensePlate.TabIndex = 61;
            this.txtLicensePlate.Text = "License";
            this.txtLicensePlate.TextChanged += new System.EventHandler(this.TxtLicensePlate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(210, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 29);
            this.label8.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "SkyBlue Wash";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Final_Project_Vispro.Properties.Resources.icons8_automatic_car_wash_100;
            this.pictureBox1.Location = new System.Drawing.Point(51, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(301, 121);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 26);
            this.btnPrint.TabIndex = 96;
            this.btnPrint.Text = "print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // paket_mobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel1);
            this.Name = "paket_mobil";
            this.Text = "paket_mobil";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Paket_mobil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPackage;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPrint;
    }
}