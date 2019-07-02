using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace association
{
    class Kartu
    {
        public bool IsValid(Karyawan karyawan)
        {
            return karyawan.Status == true;
        }
    }
}
