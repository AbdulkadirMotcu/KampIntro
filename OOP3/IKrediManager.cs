using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //interface kuralları içerir // genellikle operasyonel metotlarda kullanılır..!
    //interface birbirinin alternetifi olan ama kod içirikleri farklı olan durumlar için kullanırız.
    
    interface IKrediManager //şablona uymak zorundasın
    {
        void Hesapla();

        void BirseyYap();

       
    }
}
