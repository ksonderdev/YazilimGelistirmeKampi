using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety (tip güvenliği)
            //Do not repeat urself
            string kategoriEtiketi = "Kategori";
            int OgrenciSayisi = 32000;
            double faizOrani = 1.45;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            bool sistemeGirisYapmisMi = true;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu"); 
            }
            if(sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlar butonu");

            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
