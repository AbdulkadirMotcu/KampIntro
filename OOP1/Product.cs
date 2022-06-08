using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet tab tab hazır kodlar.
    internal class Product //Entity- Varlık Ürünün özellikleri - Bu tür classlarda "sadece özellik olur !!!!"
    {
        // id
        public int Id { get; set; }
        //Kategori id
        public int CategoryId { get; set; } //Referance Anahtarları ikinci '2' sıraya yazılır
        //Ürün ADI
        public string ProductName { get; set; }
        // Ürün Fiyatı
        public double UnitPrice { get; set; }
        // Ürün Stok
        public int UnitInStock { get; set; }

        

    }
}
