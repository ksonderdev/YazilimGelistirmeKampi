using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor ctor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; //geçici dizinin referansı = items'ın referansı(elemanlar kaybolmasın diye)
            //dizinin eleman sayısını 1 artıyoruz
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray; i++)
            {
                items[i] = tempArray[i];
            }
        }

    }
}
