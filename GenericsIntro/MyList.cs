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
       
        //Bir class new'lendiğinde çalışan buloğa constructor denir. / 'ctor' ile yaılır
        public MyList() //diret çalışır clası bir yerde newler isek otomatik çalışır.. newlendiği anda 0 elemanlı array oluşturuldu.
        {
            items = new T[0]; 
            
        }

        //her NEW lediğinde yeni referans numarısı almış olurlar UNUTMA...
        //Yeni bir referans numarısı önceki verilerin gitmesi demek....
        public void Add(T item)               
        {                                    
              //Geçiçi dizi
            T[] tempArray = items;// 101 [elma,armut]
            // 2. T[] türünde Geçiçi dizi = items'ın referansı geçici dizinin referansı olmuş olur.
            //Geçiçi dizinin referansı items refansı olur buda referans numarısı kaybolmamış olur.
            items = new T[items.Length + 1];//102   [elma,armut] [ , ,çilek ]
            //1. Yeni eleman eklemek için dizi sayısının(Length) BİR arttırır lakin yeni bir refarans değeri vericeği için önceki değerler kaybolur.
           
            for (int i = 0; i < tempArray.Length; i++)
            {   //102       //101
                items[i] = tempArray[i];//Dizinin eleman sayısını BİR arttırır lakin 
            }
                    
            items[items.Length - 1] = item;//items uzunlunun -1 olan index'e = item'eleman' //burada eklenecek son eleman eklenmiş oldu.
        }

        public int Length//ekstra bilgi listenin uzunluğunu verir
        {
             get { return items.Length; }
        }

        public T[] Items//list in itemleri sıralar
        {
            get { return items; }
        }
    }
}
