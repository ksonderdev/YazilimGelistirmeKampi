using System;

namespace ClassIntroVeri
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Serkan";
            int yas = 21;
            //kurs1 tanımladık tipi kurs
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kazım";
            kurs2.izlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyon";
            kurs3.Egitmen = "Fiko";
            kurs3.izlenmeOrani = 55;

            Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1 , kurs2 , kurs3 };

            foreach (var kurs in kurslar)
            {
                //Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen{ get; set; }
        public int izlenmeOrani { get; set; }
    }
}
