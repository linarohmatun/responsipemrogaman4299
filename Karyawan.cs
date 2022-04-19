using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4299
{
    class karyawan
    {
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }
        public int naikGaji { get; set; }

        public karyawan(int nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }

            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            naikGaji = Convert.ToInt32(tmp) + gajiBulanan;
        }
    }
}
