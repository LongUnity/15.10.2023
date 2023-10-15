using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_nhommau
{
    internal class B : Nhommau
    {
        public B() 
        {
            Loaimau = _B;
        }
        
        public override bool checkChoNhan(Nhommau cho)
        {
            return true;
        }
    }
}
