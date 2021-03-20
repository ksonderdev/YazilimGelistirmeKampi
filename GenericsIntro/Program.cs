using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Çalışacağı tipi yazmamız lazım
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

        }
    }
}
