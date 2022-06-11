using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2
{
    //Individual - GerçekMüşteri
    //miras inheritance : müşteride olan özellikler ikisindede vardır. ebeveyn
    internal class Individual:Customer
    {

        public string TcNo { get; set; }

        public string Adi { get; set; }

        public string Soyadi { get; set; }

        

    }
}
