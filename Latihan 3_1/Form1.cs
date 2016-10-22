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

        private void ubahFontdanUkuran()
        {
            Font fontLama, fontBaru;
            string namaFont;
            float ukuran = 12;
            FontStyle gaya = 0;
            byte charset = 0;

            namaFont = jenisFont.Text;

            if (string.IsNullOrEmpty(ukuranFont.Text))
            {
                ukuran = 12;
            }
            else
            {
                ukuran = float.Parse(ukuranFont.Text);
            }

            fontLama = isiKonten.SelectionFont;

            if (fontLama == null)
            {
                gaya = FontStyle.Regular;
            }
            else
            {
                gaya = fontLama.Style;
                charset = fontLama.GdiCharSet;
            }

            fontBaru = new Font(namaFont, ukuran, gaya, GraphicsUnit.Point, charset);
            isiKonten.SelectionFont = fontBaru;
            isiKonten.Focus();
        }

        private void cetakTebal_Click(object sender, EventArgs e)
        {
            Font cekFont = isiKonten.SelectionFont;
            if (cekFont != null)
            {
                isiKonten.SelectionFont = new Font(cekFont, cekFont.Style ^ FontStyle.Bold);
            }
        }

        private void cetakMiring_Click(object sender, EventArgs e)
        {
            Font cekFont = isiKonten.SelectionFont;
            if (cekFont != null)
            {
                isiKonten.SelectionFont = new Font(cekFont, cekFont.Style ^ FontStyle.Italic);
            }
        }

        private void cetakGaris_Click(object sender, EventArgs e)
        {
            Font cekFont = isiKonten.SelectionFont;
            if (cekFont != null)
            {
                isiKonten.SelectionFont = new Font(cekFont, cekFont.Style ^ FontStyle.Underline);
            }
        }

        private void gantiWarna_Click(object sender, EventArgs e)
        {
            var warna = new ColorDialog();

            if (warna.ShowDialog() == DialogResult.OK)
            {
                isiKonten.SelectionColor = warna.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                jenisFont.Items.Add(oneFontFamily.Name);
            }

            int[] uk = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int i in uk)
            {
                ukuranFont.Items.Add(i);
            }

            jenisFont.Text = this.isiKonten.Font.Name.ToString();
            ukuranFont.Text = this.isiKonten.Font.Size.ToString();
        }

        private void ukuranFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ubahFontdanUkuran();
        }

        private void jenisFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ubahFontdanUkuran();
        }
    }
}
