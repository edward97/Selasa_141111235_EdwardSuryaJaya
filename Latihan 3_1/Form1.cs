using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold != true && richTextBox1.SelectionFont.Italic == false && richTextBox1.SelectionFont.Underline == false)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold);
            }
            else if (richTextBox1.SelectionFont.Italic == true)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold | FontStyle.Italic);
            }
            else if (richTextBox1.SelectionFont.Underline == true)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Bold | FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Regular);
            }
        }

        private void miring_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Italic != true)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Italic);
            }
            else
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Regular);
            }
        }

        private void garisBawah_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Underline != true)
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Underline);
            }
            else
            {
                richTextBox1.SelectionFont = new Font("Times New Roman", 12, FontStyle.Regular);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                jenisFont.Items.Add(oneFontFamily.Name);
            }

            jenisFont.Text = this.richTextBox1.Font.Name.ToString();
            ukuranFont.Text = this.richTextBox1.Font.Size.ToString();

            richTextBox1.Focus();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
