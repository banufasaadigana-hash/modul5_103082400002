using System;

namespace modul5_103082400002
{
    // Class Penjumlahan dengan Generic Method
    public class Penjumlahan
    {
        // Method generic JumlahTigaAngka
        public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            // Menggunakan dynamic untuk memungkinkan operasi matematis
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;

            return a + b + c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("JURNAL MODUL 5 - NIM: 103082400002");
            Console.WriteLine("=========================================\n");

            // ==================================================
            // BAGIAN 4: MEMANGGIL METHOD GENERIC
            // NIM berakhiran 2 → tipe data FLOAT
            // 2-digit NIM: 10, 30, 82
            // ==================================================
            Console.WriteLine("=== DEMO GENERIC METHOD ===");
            Console.WriteLine("NIM: 103082400002 (digit terakhir = 2)");
            Console.WriteLine("Tipe data: float");
            Console.WriteLine("3 angka: 10, 30, 82\n");

            Penjumlahan penjumlahan = new Penjumlahan();

            // Input dengan tipe float sesuai ketentuan
            float angka1 = 10f;
            float angka2 = 30f;
            float angka3 = 82f;

            float hasil = penjumlahan.JumlahTigaAngka<float>(angka1, angka2, angka3);

            Console.WriteLine($"Penjumlahan: {angka1} + {angka2} + {angka3} = {hasil}");
            Console.WriteLine($"Hasil: {hasil}");

            Console.WriteLine("\nTekan Enter untuk melanjutkan...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
