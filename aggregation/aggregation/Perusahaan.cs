﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aggregation
{
    class Perusahaan
    {
        public List<Karyawan> DaftarKaryawan { get; set; } = new List<Karyawan>();
    }
}
