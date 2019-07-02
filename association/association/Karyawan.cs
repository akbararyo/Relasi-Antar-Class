using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Karyawan
    {
        public string Nama { get; set; }
        public bool Status { get; set; }

        public bool Login(Kartu kartu)
        {
            //hubungan association
            return kartu.IsValid(this);
        }
    }
}
