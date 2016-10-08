using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_2_1
{
    public partial class latihan2_1 : Form
    {
        public latihan2_1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void latihan2_1_Load(object sender, EventArgs e)
        {
            kalender.ScrollChange = 6;
            int n = 2020;
            while (n >= 2010)
            {
                DateTime awalTahun = new DateTime(n, 1, 1);
                DateTime akhirTahun = new DateTime(n, 12, 31);

                for (int i = 0; i < akhirTahun.DayOfYear; i++)
                {
                    if (awalTahun.DayOfWeek.ToString() == "Friday" || awalTahun.DayOfWeek.ToString() == "Saturday")
                    {
                        kalender.AddBoldedDate(awalTahun);
                        kalKedua.AddBoldedDate(awalTahun);
                    }
                    awalTahun = awalTahun.AddDays(1);
                }


                kalender.AddBoldedDate(new DateTime(n, 2, 2));
                kalKedua.AddBoldedDate(new DateTime(n, 2, 2));
                n--;
            }

            kalender.UpdateBoldedDates();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tambah_Click(object sender, EventArgs e)
        {
            int n = 2020;
            int tgl = Convert.ToInt32(tanggal.Value.ToString());
            int bln = bulan.SelectedIndex;

            int[] blnLengkap = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            while (n >= 2010)
            {
                kalender.AddBoldedDate(new DateTime(n, blnLengkap[bln], tgl));
                n--;
            }

            kalender.UpdateBoldedDates();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            int n = 2020;
            int tgl = Convert.ToInt32(tanggal.Value.ToString());
            int bln = bulan.SelectedIndex;

            int[] blnLengkap = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            while (n >= 2010)
            {
                kalender.RemoveBoldedDate(new DateTime(n, blnLengkap[bln], tgl));
                n--;
            }

            kalender.UpdateBoldedDates();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void kalKedua_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void kalender_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime tambahDua = new DateTime(2016, (int)comboBox2.SelectedIndex + 1, (int)comboBox1.SelectedIndex + 1);
            kalKedua.AddAnnuallyBoldedDate(tambahDua);
            kalKedua.UpdateBoldedDates();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime kurangDua = new DateTime(2016, (int)comboBox2.SelectedIndex + 1, (int)comboBox1.SelectedIndex + 1);
            kalKedua.RemoveAnnuallyBoldedDate(kurangDua);
            kalKedua.UpdateBoldedDates();
        }
    }
}
