using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Tiket Booking System");
        Console.WriteLine();

        TiketBookingSystem TiketBookingSystem = new TiketBookingSystem();

        while (true)
        {
            Console.WriteLine("1. Add tiket");
            Console.WriteLine("2. Process order");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (choice == 1)
            {
                Console.Write("Enter namapembeli: ");
                string NamaPembeli = Console.ReadLine();

                Console.WriteLine("Enter nik: ");
                int Nik = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter nomortelepon: ");
                int NomorTelepon = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter nomorkartuvaksin: ");
                int NomorKartuVaksin = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter alamatrumah: ");
                string AlamatRumah = Console.ReadLine();

                Console.Write("Enter jumlahtiket: ");
                int Jumlahtiket = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter harga per tiket: ");
                int tiketHarga = Convert.ToInt32(Console.ReadLine());

                namapembeli= new nama(NamaPembeli, Jumlahtiket, tiketHarga);
                TiketBookingSystem.AddTiketNamaPembeli(tiket);

                Console.WriteLine();
            }
            else if (choice == 2)
            {
                TiketBookingSystem.ProcessOrder();
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Thank you for using our Tiket Booking System.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine();
            }
        }
    }
}
