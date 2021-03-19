using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                Musteri musteri1 = new Musteri();
                musteri1.Ad = "Serkan";
                musteri1.soyAd = "Önder";
                musteri1.Id = 1;
                musteri1.HesapNo = 111;

                Musteri musteri2 = new Musteri();
                musteri2.Ad = "Dimitris";
                musteri2.soyAd = "Pelkas";
                musteri2.Id = 2;
                musteri2.HesapNo = 112;

            MusteriManager musteriManager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] {musteri1 , musteri2};
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(musteri1);

        }
    }
}
