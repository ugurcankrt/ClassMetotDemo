
using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Uğur";
            musteri1.Soyad = "KURT";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Can";
            musteri2.Soyad = "KURT";


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriListele(musteri1);

            musteriManager.MusteriSil(musteri1);
        }
    }
}
