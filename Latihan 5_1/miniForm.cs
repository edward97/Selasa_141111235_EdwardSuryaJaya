using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class miniForm : Form
    {
        public miniForm()
        {
            InitializeComponent();
        }

        private void miniForm_Load(object sender, EventArgs e)
        {
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static | BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.warnaBelakang.Items.Add(c.Name);
                this.kumpulanWarna.Items.Add(c.Name);
            }
        }

        private void pohon_AfterSelect(object sender, TreeViewEventArgs e)
        {
            pohon.ExpandAll();

            if (pohon.SelectedNode.Text == "Back-Color")
            {
                label1.Visible = true;
                kumpulanWarna.Visible = true;

                button1.Visible = true;
            }
            else if (pohon.SelectedNode.Text == "Back-Text")
            {
                label2.Visible = true;
                warnaBelakang.Visible = true;

                button1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                kumpulanWarna.Visible = false;

                label2.Visible = false;
                warnaBelakang.Visible = false;

                button1.Visible = false;
            }
        }

        private void kumpulanWarna_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm main = (mainForm)MdiParent;
            main.ubahBackground(kumpulanWarna.Text);
        }

        private void kumpulanWarna_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Bottom);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }

        private void warnaBelakang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void warnaBelakang_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.Bounds;
            if (e.Index >= 0)
            {
                string n = ((ComboBox)sender).Items[e.Index].ToString();
                Font f = new Font("Arial", 9, FontStyle.Regular);
                Color c = Color.FromName(n);
                Brush b = new SolidBrush(c);
                g.DrawString(n, f, Brushes.Black, rect.X, rect.Bottom);
                g.FillRectangle(b, rect.X + 110, rect.Y + 5, rect.Width - 10, rect.Height - 10);
            }
        }
    }
}
