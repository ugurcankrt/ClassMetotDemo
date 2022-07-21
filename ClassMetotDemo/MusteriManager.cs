using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {

            Console.WriteLine("Müşteri ekleme işlemi başarılı sonuçlandı. "+musteri.Ad+" "+musteri.Soyad);

        }

        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine("Müşteri silme işlemi başarılı sonuçlandı. "+ musteri.Ad + " " + musteri.Soyad);


        }

        public void MusteriListele(Musteri musteri)
        {

            Console.WriteLine("Müşteri listeleme işlemi başarılı sonuçlandı. " + musteri.Ad + " " + musteri.Soyad);


        }

    }
}
