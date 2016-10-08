namespace Latihan_2_1
{
    partial class latihan2_1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.kalender = new System.Windows.Forms.MonthCalendar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tanggal = new System.Windows.Forms.NumericUpDown();
            this.bulan = new System.Windows.Forms.DomainUpDown();
            this.tambah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kalKedua = new System.Windows.Forms.MonthCalendar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(705, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hapus);
            this.tabPage1.Controls.Add(this.tambah);
            this.tabPage1.Controls.Add(this.bulan);
            this.tabPage1.Controls.Add(this.tanggal);
            this.tabPage1.Controls.Add(this.kalender);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(697, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DomainUpDown";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // kalender
            // 
            this.kalender.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.kalender.Location = new System.Drawing.Point(4, 36);
            this.kalender.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.kalender.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.kalender.Name = "kalender";
            this.kalender.TabIndex = 5;
            this.kalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kalender_DateChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.kalKedua);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(697, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ComboBox";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(143, 12);
            this.tanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tanggal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(51, 20);
            this.tanggal.TabIndex = 6;
            this.tanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bulan
            // 
            this.bulan.Items.Add("January");
            this.bulan.Items.Add("February");
            this.bulan.Items.Add("March");
            this.bulan.Items.Add("April");
            this.bulan.Items.Add("May");
            this.bulan.Items.Add("June");
            this.bulan.Items.Add("July");
            this.bulan.Items.Add("August");
            this.bulan.Items.Add("September");
            this.bulan.Items.Add("October");
            this.bulan.Items.Add("November");
            this.bulan.Items.Add("December");
            this.bulan.Location = new System.Drawing.Point(211, 12);
            this.bulan.Name = "bulan";
            this.bulan.Size = new System.Drawing.Size(102, 20);
            this.bulan.TabIndex = 7;
            // 
            // tambah
            // 
            this.tambah.Location = new System.Drawing.Point(361, 9);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(75, 23);
            this.tambah.TabIndex = 8;
            this.tambah.Text = "Add";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // hapus
            // 
            this.hapus.Location = new System.Drawing.Point(459, 9);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(75, 23);
            this.hapus.TabIndex = 9;
            this.hapus.Text = "Delete";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kalKedua
            // 
            this.kalKedua.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.kalKedua.Location = new System.Drawing.Point(4, 36);
            this.kalKedua.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.kalKedua.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.kalKedua.Name = "kalKedua";
            this.kalKedua.TabIndex = 10;
            this.kalKedua.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.kalKedua_DateChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            "31"});
            this.comboBox1.Location = new System.Drawing.Point(155, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(44, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBox2.Location = new System.Drawing.Point(216, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(94, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // latihan2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 399);
            this.Controls.Add(this.tabControl1);
            this.Name = "latihan2_1";
            this.Text = "Latihan 2_1";
            this.Load += new System.EventHandler(this.latihan2_1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tanggal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MonthCalendar kalender;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.DomainUpDown bulan;
        private System.Windows.Forms.NumericUpDown tanggal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar kalKedua;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

