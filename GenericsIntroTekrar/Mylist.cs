using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntroTekrar
{
    class Mylist<T>
    {
        T[] items;
        //constructor
        public Mylist()
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items; //tempArray=geçici dizi, adres değişikliği yapıldığında eski adresi tutar.
            items = new T[items.Length+1]; //dizi elaman satysını +1 arttırmak ve adres değişir
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; // tüm değerleri sırasıyla geri veriyor.
            }
            items[items.Length - 1] = item;//items in en son elemanı.
        }
    }
}
