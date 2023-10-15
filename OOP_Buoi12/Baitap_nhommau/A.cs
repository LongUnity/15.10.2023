using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_nhommau
{
    internal class A:Nhommau
    {
        public A()
        {
            Loaimau = _A;
        }
       
        public override bool checkChoNhan(Nhommau cho)
        {
            return true;
        }

    }
}
