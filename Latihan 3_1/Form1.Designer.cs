namespace Latihan_3_1
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tebal = new System.Windows.Forms.Button();
            this.miring = new System.Windows.Forms.Button();
            this.garisBawah = new System.Windows.Forms.Button();
            this.jenisFont = new System.Windows.Forms.ComboBox();
            this.ukuranFont = new System.Windows.Forms.ComboBox();
            this.warnaFont = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(24, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(482, 313);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tebal
            // 
            this.tebal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tebal.Location = new System.Drawing.Point(60, 8);
            this.tebal.Name = "tebal";
            this.tebal.Size = new System.Drawing.Size(30, 32);
            this.tebal.TabIndex = 1;
            this.tebal.Text = "B";
            this.tebal.UseVisualStyleBackColor = true;
            this.tebal.Click += new System.EventHandler(this.button1_Click);
            // 
            // miring
            // 
            this.miring.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miring.Location = new System.Drawing.Point(96, 8);
            this.miring.Name = "miring";
            this.miring.Size = new System.Drawing.Size(30, 32);
            this.miring.TabIndex = 1;
            this.miring.Text = "I";
            this.miring.UseVisualStyleBackColor = true;
            this.miring.Click += new System.EventHandler(this.miring_Click);
            // 
            // garisBawah
            // 
            this.garisBawah.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garisBawah.Location = new System.Drawing.Point(132, 8);
            this.garisBawah.Name = "garisBawah";
            this.garisBawah.Size = new System.Drawing.Size(30, 32);
            this.garisBawah.TabIndex = 1;
            this.garisBawah.Text = "U";
            this.garisBawah.UseVisualStyleBackColor = true;
            this.garisBawah.Click += new System.EventHandler(this.garisBawah_Click);
            // 
            // jenisFont
            // 
            this.jenisFont.FormattingEnabled = true;
            this.jenisFont.Location = new System.Drawing.Point(168, 8);
            this.jenisFont.Name = "jenisFont";
            this.jenisFont.Size = new System.Drawing.Size(163, 21);
            this.jenisFont.TabIndex = 2;
            // 
            // ukuranFont
            // 
            this.ukuranFont.FormattingEnabled = true;
            this.ukuranFont.Items.AddRange(new object[] {
            "8",
            "9",
            "11",
            "12",
            "14",
            "16",
            "18",
            "22",
            "24",
            "26",
            "32",
            "36",
            "72"});
            this.ukuranFont.Location = new System.Drawing.Point(337, 8);
            this.ukuranFont.Name = "ukuranFont";
            this.ukuranFont.Size = new System.Drawing.Size(36, 21);
            this.ukuranFont.TabIndex = 2;
            // 
            // warnaFont
            // 
            this.warnaFont.FormattingEnabled = true;
            this.warnaFont.Location = new System.Drawing.Point(379, 8);
            this.warnaFont.Name = "warnaFont";
            this.warnaFont.Size = new System.Drawing.Size(77, 21);
            this.warnaFont.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 384);
            this.Controls.Add(this.warnaFont);
            this.Controls.Add(this.ukuranFont);
            this.Controls.Add(this.jenisFont);
            this.Controls.Add(this.garisBawah);
            this.Controls.Add(this.miring);
            this.Controls.Add(this.tebal);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button tebal;
        private System.Windows.Forms.Button miring;
        private System.Windows.Forms.Button garisBawah;
        private System.Windows.Forms.ComboBox jenisFont;
        private System.Windows.Forms.ComboBox ukuranFont;
        private System.Windows.Forms.ComboBox warnaFont;
    }
}

