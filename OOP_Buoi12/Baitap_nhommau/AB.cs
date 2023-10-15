using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_nhommau
{
    internal class AB:Nhommau
    {
        public AB()
        {
            Loaimau = _AB;
        }
       
        public override bool checkChoNhan(Nhommau cho)
        {
            return true;
        }
    }
}
