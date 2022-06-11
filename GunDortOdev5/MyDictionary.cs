using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunDortOdev5
{
    internal class MyDictionary<TKey, TValue> 
    {
        TKey[] keys;
        TValue[] values;

        public MyDictionary()//MyDictionary kullanıldığıda default olara keys ve values olarak 0 elemanlı dizi tanımlar
        {
            keys = new TKey[0]; 
            values = new TValue[0]; 
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = keys;//TKey türünde geçici dizi oluşturulup elemanları geçici olarak tutar
            TValue[] tempValues = values;    

            keys = new TKey[keys.Length +1];//keys'in uzunluğun +1 kadar yeni bir dizi tanımlanır.
            values = new TValue[values.Length +1];

            for (int i = 0; i < tempKeys.Length; i++)//geçici dizinin elemanlarını sırasıyla döner ve asıl diziye [i] elemanları aktarır
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }

            keys[keys.Length - 1] = key; //keyden gelen veriyi, keys'in uzunluğunun bir eksiği -1 ne aktarır... İndex yapısı 0 başladığı için -1 denir
            values[keys.Length - 1] = value;
        }

        public int Count
        {
            get { return keys.Length; }
        }

       

    }
}
