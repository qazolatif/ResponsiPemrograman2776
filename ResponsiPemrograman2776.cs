using System;

namespace ResponsiPemrograman2776
{
    public class Karyawan
    {
        public string NO {get;set;}
        public int NIK {get;set;}
        public string Nama {get;set;}
        public int gajiBulanan {get;set;}

        public Karyawan(string no, int nik, string nama, int gajibulanan)
        {
            NO = no;
            NIK = nik;
            Nama = nama;

            if(gajibulanan < 0)
            {
                this.gajiBulanan = 0;
            }
            
            else
            {
                this.gajiBulanan = gajibulanan;
            }
        }
        
        public void infoKaryawan()
        {
            Console.WriteLine("{0} {1} {2}\t{3}", NO, NIK, Nama, gajiBulanan);
        }

        public void infoNaikGaji()
        {
            double naikGaji = 0;
            naikGaji =  0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(naikGaji);
            Console.WriteLine("{0} {1} {2}\t{3}", NO, NIK, Nama, gajiBulanan);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan("1.", 190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan("2.", 190302124, "Jono", 2000000);

            Console.WriteLine("No. NIK/Nama \t\t Gaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            karyawan1.infoKaryawan();
            karyawan2.infoKaryawan();

            Console.WriteLine("\n\nAlhamdulillah kenaikan gaji 10%!!");

            Console.WriteLine("No. NIK/Nama \t\t Gaji Bulanan");
            Console.WriteLine("---------------------------------------------");
            karyawan1.infoNaikGaji();
            karyawan2.infoNaikGaji();

            Console.ReadKey();
        }
    }
}
