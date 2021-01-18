using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Eren Arı";
            musteri1.Yasi = 16;
            musteri1.HarcamaLimiti = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Elon Musk";
            musteri2.Yasi = 40;
            musteri2.HarcamaLimiti = 179200000000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Engin Demiroğ";
            musteri3.Yasi = 35;
            musteri3.HarcamaLimiti = 100000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Müşteri ID : "+musteri.Id);
                Console.WriteLine("Müşteri isimi : "+musteri.Adi);
                Console.WriteLine("Müşteri harcama limiti : "+musteri.HarcamaLimiti+" Dolar");
                Console.WriteLine("*********************");
            }


        }
    }
}
