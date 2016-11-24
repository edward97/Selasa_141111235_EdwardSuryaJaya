using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolleyBall_Problem
{
    public partial class VolleyBall_Problem : Form
    {
        public VolleyBall_Problem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int batas = 1000000007;
            var q = Convert.ToInt32(Txt1.Text);
            var r = Convert.ToInt32(Txt2.Text);

            int hasil;

            if (q < r)
            {
                pindahPosisi(ref q, ref r);
            }
            if (!cekValidasi(q, r))
            {
                hasil = 0;
            }
            else
            {
                if (q > 25)
                {
                    hasil = kombinasi(24, 24, batas);
                    hasil = (int)((((long)hasil) * pangkat(2, r - 24, batas)) * batas);
                }
                else
                {
                    hasil = kombinasi(q - 1, r, batas);
                }
            }
            TxtHasil.Text = hasil.ToString();
        }

        public static bool cekValidasi(int x, int y)
        {
            if (x < 25)
            {
                return false;
            }
            if (x == 25)
            {
                return y <= 23;
            }
            return y == (x - 2);
        }

        public static void pindahPosisi<P>(ref P kiri, ref P kanan)
        {
            P temp;
            temp = kiri;
            kiri = kanan;
            kanan = temp;
        }

        public static int kombinasi(int x, int y, int mod)
        {
            if (x < y)
                pindahPosisi(ref x, ref y);
            if (x < 1 || y < 1)
                return 1;

            var row = new int[y];
            for (var i = 0; i < y; row[i++] = 1)
            {
                for (int j = i - 1; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
            }

            --y;
            int sum = row[y];
            for (int i = 0; i < x; ++i)
            {
                for (int j = y; j > 0; --j)
                {
                    row[j] = (row[j] + row[j - 1]) % mod;
                }
                sum = (sum + row[y]) % mod;
            }
            return sum;
        }

        public static int pangkat(int basis, int exp, int mod)
        {
            if (exp < 2)
            {
                return (exp < 1) ? 1 : basis;
            }
            long total = pangkat(basis, exp >> 1, mod);
            total = (total * total) % mod;
            return ((exp & 1) == 1) ? (int)((exp * basis) % mod) : (int)(total);
        }
    }
}
