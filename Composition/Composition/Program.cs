using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Demo Relasi Komposisi";

            //membuat objek mobil
            Mobil mobil = new Mobil();
            mobil.Merk = "BMW";

            Console.WriteLine("Merk mobil: {0}, Tipe mesin: {1}", mobil.Merk, mobil.GetInfoMesin().Type);

            Console.ReadKey();
        }
    }
}
