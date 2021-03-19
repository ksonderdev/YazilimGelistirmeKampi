using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Proglamlamaya başlangıç için temel kurs", "Java", "Phyton", "C#" };
            //array(dizi)
            for (int i= 1; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            //dizileri dolaşmaya yarar
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
