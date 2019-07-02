using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Mobil
    {
        public string Merk { get; set; }
        private Mesin mesin;

        public Mobil()
        {
            //hubungan composition
            mesin = new Mesin();
            mesin.Type = "INLINE";
        }
        public Mesin GetInfoMesin()
        {
            return mesin;
        }
    }
}
