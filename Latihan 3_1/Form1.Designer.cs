﻿namespace Latihan_3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.isiKonten = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.cetakTebal = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cetakMiring = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cetakGaris = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.jenisFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ukuranFont = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.gantiWarna = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // isiKonten
            // 
            this.isiKonten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isiKonten.Location = new System.Drawing.Point(12, 36);
            this.isiKonten.Name = "isiKonten";
            this.isiKonten.Size = new System.Drawing.Size(340, 276);
            this.isiKonten.TabIndex = 5;
            this.isiKonten.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.cetakTebal,
            this.toolStripSeparator1,
            this.cetakMiring,
            this.toolStripSeparator2,
            this.cetakGaris,
            this.toolStripSeparator3,
            this.jenisFont,
            this.toolStripSeparator5,
            this.ukuranFont,
            this.toolStripSeparator4,
            this.gantiWarna,
            this.toolStripSeparator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(364, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // cetakTebal
            // 
            this.cetakTebal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cetakTebal.Image = ((System.Drawing.Image)(resources.GetObject("cetakTebal.Image")));
            this.cetakTebal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cetakTebal.Name = "cetakTebal";
            this.cetakTebal.Size = new System.Drawing.Size(23, 22);
            this.cetakTebal.Text = "toolStripButton1";
            this.cetakTebal.Click += new System.EventHandler(this.cetakTebal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // cetakMiring
            // 
            this.cetakMiring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cetakMiring.Image = ((System.Drawing.Image)(resources.GetObject("cetakMiring.Image")));
            this.cetakMiring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cetakMiring.Name = "cetakMiring";
            this.cetakMiring.Size = new System.Drawing.Size(23, 22);
            this.cetakMiring.Text = "toolStripButton2";
            this.cetakMiring.Click += new System.EventHandler(this.cetakMiring_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cetakGaris
            // 
            this.cetakGaris.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cetakGaris.Image = ((System.Drawing.Image)(resources.GetObject("cetakGaris.Image")));
            this.cetakGaris.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cetakGaris.Name = "cetakGaris";
            this.cetakGaris.Size = new System.Drawing.Size(23, 22);
            this.cetakGaris.Text = "toolStripButton3";
            this.cetakGaris.Click += new System.EventHandler(this.cetakGaris_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // jenisFont
            // 
            this.jenisFont.Name = "jenisFont";
            this.jenisFont.Size = new System.Drawing.Size(121, 25);
            this.jenisFont.SelectedIndexChanged += new System.EventHandler(this.jenisFont_SelectedIndexChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ukuranFont
            // 
            this.ukuranFont.Name = "ukuranFont";
            this.ukuranFont.Size = new System.Drawing.Size(75, 25);
            this.ukuranFont.SelectedIndexChanged += new System.EventHandler(this.ukuranFont_SelectedIndexChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // gantiWarna
            // 
            this.gantiWarna.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gantiWarna.Image = ((System.Drawing.Image)(resources.GetObject("gantiWarna.Image")));
            this.gantiWarna.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.gantiWarna.Name = "gantiWarna";
            this.gantiWarna.Size = new System.Drawing.Size(23, 22);
            this.gantiWarna.Text = "toolStripButton4";
            this.gantiWarna.Click += new System.EventHandler(this.gantiWarna_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 324);
            this.Controls.Add(this.isiKonten);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Latihan 3_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox isiKonten;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton cetakTebal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton cetakMiring;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cetakGaris;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripComboBox jenisFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox ukuranFont;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton gantiWarna;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    }
}

