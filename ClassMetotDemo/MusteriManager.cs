using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle( Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.soyAd + " " +"eklendi!");
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.soyAd + " " +"silindi!");

        }

        public void MusteriListele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : " + musteri.Ad + " " +"Müşteri Soyadı : " + musteri.soyAd + " " + "Müşteri Id : " + musteri.Id + " " +  " Müşteri Hesap No : " + musteri.HesapNo);

            }
        }

    }
}
