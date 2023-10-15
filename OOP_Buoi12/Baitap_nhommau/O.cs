using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_nhommau
{
    internal class O : Nhommau
    {
        public O() 
        {
            Loaimau = _O;
        }
       
        public override bool checkChoNhan(Nhommau cho)
        {
            return true;
        }
    }
}
