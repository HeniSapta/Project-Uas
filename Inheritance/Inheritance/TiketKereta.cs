using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

nnamespace PesanTiket
{{ 
    internal class TiketKereta
    {
        public string NamaPembeli { get; set; }
        public int NIK { get; set; }
        public int NomorTelepon { get; set; }
        public int NomorKartuVaksin { get; set; }
        public string AlamatRumah { get; set; }
        public int Jumlahtiket {get; set; }
        public int Harga { get; set; }

        public TiketKereta(string nama, int nik, int nomortelepon, int nomorkartuvaksin, string alamatrumah, int jumlahtiket, int harga)
        {
            NamaPembeli = nama;
            NIK = nik;
            NomorTelepon = nomortelepon;
            NomorKartuVaksin = nomorkartuvaksin;
            AlamatRumah = alamatrumah;
            Jumlahtiket = jumlahtiket;
            Harga = harga;
        }

        public int CalculateTotalHarga()
        {
            return Jumlahtiket * Harga;
        }
    }

    class TiketBookingSystem
    {
        private List<TiketKereta> TiketKereta;

        public TiketBookingSystem()
        {
            TiketKereta = new List<TiketKereta>();
        }

        public void AddTiketKereta(TiketKereta tiketkereta)
        {
            TiketKereta.Add(TiketKereta);
            Console.WriteLine("TiketKereta added successfully.");
        }

        public void ProcessOrder()
        {
            if (TiketKereta.Count == 0)
            {
                Console.WriteLine("No TiketKereta found.");
                return;
            }

            Console.WriteLine("Processing TiketKereta order:");
            Console.WriteLine("------------------------");
            int totalHarga = 0;

            foreach (TiketKereta tiket in TiketKereta)
            {
                int tiketHarga = tiket.CalculateTotalHarga();
                Console.WriteLine($"TiketKereta: {tiket.NamaPembeli}, Jumlahtiket: {tiket.Jumlahtiket}, Harga per tiket: {tiket.Harga:C}, Total Harga: {tiketHarga:C}");
                totalHarga += totalHarga;
            }

            Console.WriteLine("------------------------");
            Console.WriteLine($"Total Harga for all tiket: {totalHarga:C}");
            Console.WriteLine("TiketKereta order processed successfully.");
        }
    }
}  