using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        public int Id { get; set; }
        //kategori ıd si
        public int CategoryId { get; set; }
        //ürün adı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        //ürün stok
        public int UnitInStock { get; set; }

        


    }
}
