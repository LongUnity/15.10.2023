using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_nhommau
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;



            DSNM ds = new DSNM();

            //ds.nhap();
            ds.cau2();
            //ds.cau3();






            Console.ReadKey();
        }
    }
}
