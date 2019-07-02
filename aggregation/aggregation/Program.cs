using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek karyawan 1
            Karyawan karyawan1 = new Karyawan();
            karyawan1.Nama = "Paijo";

            //membuat objek karyawan 2
            Karyawan karyawan2 = new Karyawan();
            karyawan2.Nama = "Jhono";

            //membuat objek perusahaan
            Perusahaan perusahaan = new Perusahaan();

            //hubungan aggregation
            perusahaan.DaftarKaryawan.Add(karyawan1);
            perusahaan.DaftarKaryawan.Add(karyawan2);

            int noUrut = 1;

            Console.WriteLine("Daftar karyawan: "); //menampilkan data karyawan
            foreach (Karyawan karyawan in perusahaan.DaftarKaryawan)
            {
                Console.WriteLine("{0}. {1}", noUrut, karyawan.Nama);
                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
