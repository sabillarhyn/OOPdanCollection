using System;
using System.Collections.Generic;
using System.Text;

namespace OOPCollection
{
    public abstract class karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }

        public abstract double gaji();
    }
}
