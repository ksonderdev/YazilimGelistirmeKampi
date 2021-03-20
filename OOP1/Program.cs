using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            
            //bu şekilde de yazılabilir

            Product product2 = new Product {Id = 2 , CategoryId = 5, UnitsInStock = 5 , ProductName = "Kalem" , UnitPrice = 35};
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //test(product.name değişti ama int sayi degismedi.)
            //sayinin sadece değerini yolladık sayıyla olan bağlantımız bitti
            //maindeki sayiyla managerdeki sayinin bir baglantisi yok!
            //productName referans tipinde olduğu için değişti.adresiyle fonksiyona gitti.bu nedenle adreste değişti.
            //int,double,bool deger tipi
            //class,diziler,abstrack class,interface referans tipidir!
            //int sayi = 100;
            //productManager.BiSeyYap(sayi);
            //Console.WriteLine(sayi);
            //Console.WriteLine(product1.ProductName);



        }
    }
}
