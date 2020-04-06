using System;
using System.Collections.Generic;
using System.Linq;

namespace tugas_implementasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nama: ");
            string nama_mhs = Console.ReadLine();
            if (string.IsNullOrEmpty(nama_mhs))
            {
                Console.Write("Nama tidak boleh kosong");
                Environment.Exit(0);
            }

            if (nama_mhs.Any(char.IsDigit))
            {
                Console.Write("Nama tidak boleh ada angka");
                Environment.Exit(0);
            }

            Console.Write("STB: ");
            string stb_mhs = Console.ReadLine();
            if (string.IsNullOrEmpty(stb_mhs))
            {
                Console.Write("STB tidak boleh kosong");
                Environment.Exit(0);
            }

            if (stb_mhs.Length > 6)
            {
                Console.Write("STB max 6 digit");
                Environment.Exit(0);
            }

            IDictionary<string, string> jurusan = new Dictionary<string, string>();
            jurusan["1"] = "Teknik Informatika";
            jurusan["2"] = "Sistem Informasi";
            jurusan["3"] = "Manajemen Informatika";

            foreach (KeyValuePair<string, string> entry in jurusan)
            {
                Console.WriteLine(entry.Key+". "+entry.Value);
            }

            Console.Write("Pilih nomor jurusan: ");
            string nomor_jurusan = Console.ReadLine();
            if (string.IsNullOrEmpty(nomor_jurusan))
            {
                Console.Write("Nomor jurusan tidak boleh kosong");
                Environment.Exit(0);
            }

            if (!nomor_jurusan.Any(char.IsDigit))
            {
                Console.Write("Hanya boleh input nomor");
                Environment.Exit(0);
            }

            if (nomor_jurusan.Length > 1)
            {
                Console.Write("Nomor jurusan hanya boleh 1 digit");
                Environment.Exit(0);
            }

            if (!jurusan.ContainsKey(nomor_jurusan))
            {
                Console.Write("Nomor jurusan "+nomor_jurusan+" tidak ditemukan");
                Environment.Exit(0);
            }

            string jurusan_pilihan = jurusan[nomor_jurusan];

            Console.WriteLine("Halo "+nama_mhs+", selamat datang di "+jurusan_pilihan+". Nomor Induk Mahasiswa anda adalah "+stb_mhs);
        }
    }
}
