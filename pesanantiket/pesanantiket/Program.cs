using System; 

public class Person
{
    public string Nama { get; set; }

    public string NIK { get; set; }
    public string NoTelp { get; set; }
    public string NomorKartuVaksin { get; set; }
    public string Alamat { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("====== Data Pesan Tiket ======");
        Console.WriteLine("Nama                 : " + Nama);
        Console.WriteLine("NIK                  : " + NIK);
        Console.WriteLine("Nomor Telp           : " + NoTelp);
        Console.WriteLine("Nomor Kartu Vaksin   : " + NomorKartuVaksin);
        Console.WriteLine("Alamat               : " + Alamat);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person();

        Console.Write("Masukkan Nama: ");
        person.Nama = Console.ReadLine();

        Console.Write("Masukkan NIK: ");
        person.NIK = Console.ReadLine();

        Console.Write("Masukkan Nomor Telepon: ");
        person.NoTelp = Console.ReadLine();

        Console.Write("Masukkan Nomor Kartu Vaksin: ");
        person.NomorKartuVaksin = Console.ReadLine();

        Console.Write("Masukkan Alamat: ");
        person.Alamat = Console.ReadLine();

        person.DisplayInfo();
    }
}