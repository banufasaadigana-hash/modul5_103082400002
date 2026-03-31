using System;
using System.Collections.Generic;

namespace modul5_103082400002
{
    // ==================================================
    // CLASS GENERIC: SimpleDataBase
    // ==================================================
    public class SimpleDataBase<T>
    {
        // Properties
        private List<T> storedData;
        private List<DateTime> inputDates;

        // Constructor
        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        // Method untuk menambah data baru
        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        // Method untuk menampilkan semua data
        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i].ToUniversalTime()}");
            }
        }
    }

    // ==================================================
    // CLASS Penjumlahan (dari langkah sebelumnya)
    // ==================================================
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
            // BAGIAN 4 & 6: DEMO GENERIC METHOD DAN GENERIC CLASS
            // ==================================================

            // ---------- DEMO GENERIC METHOD ----------
            Console.WriteLine("=== 1. DEMO GENERIC METHOD ===");
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
            Console.Clear();            Console.WriteLine($"Penjumlahan: {angka1} + {angka2} + {angka3} = {hasil}\n");

            // ---------- DEMO GENERIC CLASS ----------
            Console.WriteLine("=== 2. DEMO GENERIC CLASS (SimpleDataBase) ===");
            Console.WriteLine("Menambahkan 3 data: 10, 30, 82 (float)\n");

            // Membuat instance SimpleDataBase dengan tipe float
            SimpleDataBase<float> dataBase = new SimpleDataBase<float>();

            // Menambahkan data (2-digit dari NIM)
            dataBase.AddNewData(10f);
            System.Threading.Thread.Sleep(100); // Delay agar waktu berbeda
            dataBase.AddNewData(30f);
            System.Threading.Thread.Sleep(100);
            dataBase.AddNewData(82f);

            // Menampilkan semua data
            dataBase.PrintAllData();

            Console.WriteLine("\n=========================================");
            Console.WriteLine("Program selesai!");
            Console.WriteLine("Tekan Enter untuk keluar...");
            Console.ReadLine();
            }
    }
}
