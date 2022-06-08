using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T> //mylistimde T ile çalışıcam   
    {
        T[] items;
        //constructor Clası new ler ise otomatik olarak çalışır
        public MyList()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
                //Geçiçi array
            T[] tempArray = items; //Geçiçi dizinin referansı items refansı olur buda referans numarısı kaybolmamış olur.
            items = new T[items.Length + 1]; //eklemek için eleman sayısını 1 arttırır.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
