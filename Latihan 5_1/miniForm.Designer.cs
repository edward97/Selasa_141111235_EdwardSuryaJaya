namespace Latihan_5_1
{
    partial class miniForm
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
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Back-Color");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Back-Text");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Color", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44});
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Coming Soon !");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Coming Soon !");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Coming Soon !", new System.Windows.Forms.TreeNode[] {
            treeNode46,
            treeNode47});
            this.pohon = new System.Windows.Forms.TreeView();
            this.warnaBelakang = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kumpulanWarna = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pohon
            // 
            this.pohon.Location = new System.Drawing.Point(12, 12);
            this.pohon.Name = "pohon";
            treeNode43.Name = "Node1";
            treeNode43.Text = "Back-Color";
            treeNode44.Name = "Node2";
            treeNode44.Text = "Back-Text";
            treeNode45.Name = "Node0";
            treeNode45.Text = "Color";
            treeNode46.Name = "Node2";
            treeNode46.Text = "Coming Soon !";
            treeNode47.Name = "Node5";
            treeNode47.Text = "Coming Soon !";
            treeNode48.Name = "Node1";
            treeNode48.Text = "Coming Soon !";
            this.pohon.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode45,
            treeNode48});
            this.pohon.Size = new System.Drawing.Size(127, 210);
            this.pohon.TabIndex = 1;
            this.pohon.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.pohon_AfterSelect);
            // 
            // warnaBelakang
            // 
            this.warnaBelakang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.warnaBelakang.FormattingEnabled = true;
            this.warnaBelakang.Location = new System.Drawing.Point(145, 104);
            this.warnaBelakang.Name = "warnaBelakang";
            this.warnaBelakang.Size = new System.Drawing.Size(167, 21);
            this.warnaBelakang.TabIndex = 9;
            this.warnaBelakang.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.warnaBelakang_DrawItem);
            this.warnaBelakang.SelectedIndexChanged += new System.EventHandler(this.warnaBelakang_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kumpulanWarna
            // 
            this.kumpulanWarna.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kumpulanWarna.FormattingEnabled = true;
            this.kumpulanWarna.Location = new System.Drawing.Point(145, 35);
            this.kumpulanWarna.Name = "kumpulanWarna";
            this.kumpulanWarna.Size = new System.Drawing.Size(167, 21);
            this.kumpulanWarna.TabIndex = 7;
            this.kumpulanWarna.Visible = false;
            this.kumpulanWarna.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.kumpulanWarna_DrawItem);
            this.kumpulanWarna.SelectedIndexChanged += new System.EventHandler(this.kumpulanWarna_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text Background";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Background Color";
            this.label1.Visible = false;
            // 
            // miniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 234);
            this.Controls.Add(this.warnaBelakang);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kumpulanWarna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pohon);
            this.Name = "miniForm";
            this.Text = "miniForm";
            this.Load += new System.EventHandler(this.miniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView pohon;
        private System.Windows.Forms.ComboBox warnaBelakang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox kumpulanWarna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}