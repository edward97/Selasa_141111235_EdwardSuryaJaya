﻿namespace VolleyBall_Problem
{
    partial class VolleyBall_Problem
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
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtHasil
            // 
            this.TxtHasil.Location = new System.Drawing.Point(156, 25);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.ReadOnly = true;
            this.TxtHasil.Size = new System.Drawing.Size(100, 20);
            this.TxtHasil.TabIndex = 7;
            // 
            // BtnHitung
            // 
            this.BtnHitung.Location = new System.Drawing.Point(31, 64);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(100, 23);
            this.BtnHitung.TabIndex = 6;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.BtnHitung_Click);
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(31, 38);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 20);
            this.Txt2.TabIndex = 5;
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(31, 12);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 20);
            this.Txt1.TabIndex = 4;
            // 
            // VolleyBall_Problem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 103);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.BtnHitung);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Name = "VolleyBall_Problem";
            this.Text = "VolleyBall_Problem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHasil;
        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt1;
    }
}
