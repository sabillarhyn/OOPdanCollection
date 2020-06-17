using System;
using System.Collections.Generic;

namespace OOPCollection
{
    class Program
    {
        public static void Main(string[] args)
        {
            karyawantetap karyawantetap = new karyawantetap();
            karyawantetap.nik = "123-234-345";
            karyawantetap.nama = " Michael Suyama";
            karyawantetap.gajibulanan = 4000000;

            karyawanharian karyawanharian = new karyawanharian();
            karyawanharian.nik = "123-321-346";
            karyawanharian.nama = "Laura Callahan";
            karyawanharian.jumlahjamkerja = 8;
            karyawanharian.upahperjam = 13000;

            sales sales = new sales();
            sales.nik = "123-333-347";
            sales.nama = "Andrew Fuller";
            sales.jumlahpenjualan = 30;
            sales.komisi = 45000;

            List<karyawan> listkaryawan = new List<karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;

            foreach (karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3:N0}", noUrut, karyawan.nik, karyawan.nama, karyawan.gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
