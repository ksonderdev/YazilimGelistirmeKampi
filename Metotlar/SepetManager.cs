﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler! Sepete Eklendi : " + product.Adi);
        }

        public void Ekle2(string ProductAdi, string Aciklama , double Fiyat, int stokAdedi)
        {
            Console.WriteLine(" Tebrikler! Sepete Eklendi : " + ProductAdi + Aciklama + Fiyat + stokAdedi);
        }
    }
}
