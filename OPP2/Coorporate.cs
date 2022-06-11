using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP2
{
    //Coorporate - TüzelKişi
    //miras inheritance :
    internal class Coorporate:Customer
    {
        
        public string SirketAdi { get; set; }

        public string VergiNo { get; set; }
    }
}
