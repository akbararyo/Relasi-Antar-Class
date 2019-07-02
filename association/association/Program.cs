using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek kartu
            Kartu kartu = new Kartu();

            //membuat objek karyawan
            Karyawan karyawan = new Karyawan();
            karyawan.Nama = "Paijo";
            karyawan.Status = true; //aktif

            //hubungan association
            if (karyawan.Login(kartu))
            {
                Console.WriteLine("Data karyawan valid");
            }
            else
            {
                Console.WriteLine("Data karyawan tidak valid");
            }
            Console.ReadKey();
        }
    }
}
