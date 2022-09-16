using System;
using System.Dynamic;
using System.Security.Cryptography;

namespace MCCDTS
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Absensi Perusahaan X");
            Console.WriteLine("Silahkan Masukkan Data Anda");

            int IdPegawai;
            string Nama, Jabatan;


            Console.Write("Nama :");
            Nama = Console.ReadLine();
            Console.Write("IdPegawai :");
            IdPegawai = int.Parse(Console.ReadLine());
            Console.Write("IdPegawai :");
            Jabatan = Console.ReadLine();

            string pilihan;
            do
            {
                Console.WriteLine("Masukkan Pilihan Absen (1/2) :");
                int absen = int.Parse(Console.ReadLine());
                switch (absen)
                {
                    case 1:
                        sore();
                        break;
                    case 2:
                        pagi();
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Apa Anda Ingin Melanjutkan? y/t");
                pilihan = Console.ReadLine();
            } while (pilihan == "y");
           


        }
    public static void sore()
        {
            Console.WriteLine("anda Absen sore");
        }
    public static void pagi()
        {
            Console.WriteLine("anda Absen pagi");
        }





    }
}
