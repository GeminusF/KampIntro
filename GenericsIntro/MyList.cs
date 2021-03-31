using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>//T typedan gelir class bele vere bilersen
    {
        T[] items;
        //constructor . classimizi bir yerde newlerssek constructor avtomatik olaaraq isleyir
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempItems = items; //new deyib yeni referans numarasi alanda kohne elemanlarimim ucmasin deye onu gecici bir arraye emanet eleyirem , referans numarasini
            items = new T[items.Length + 1] ;

            for (int i = 0; i < tempItems.Length; i++) // emanet verdiyimiz elemanlari aliriq
            {
                items[i] = tempItems[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
