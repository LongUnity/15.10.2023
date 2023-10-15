using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_nhommau
{
    internal class DSNM
    {
        public List<Nhommau> ds { get; set; }
        public DSNM() { }

        public void nhap()
        {
            ds = new List<Nhommau>();

            Console.WriteLine("Nhập số lượng người cho thông tin nhóm máu: ");
            int sl = int.Parse(Console.ReadLine());
            for(int i = 0; i < sl; i++) { 
                Console.WriteLine("1.O");
                Console.WriteLine("2.A");
                Console.WriteLine("3.B");
                Console.WriteLine("4.AB");
                Console.WriteLine("0.exit");
                Console.WriteLine("Nhập lựa chọn nhóm máu");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Nhommau o = new O();
                        o.nhap();
                        ds.Add(o);
                        break;
                    case 2:
                        Nhommau a = new A();
                        a.nhap();
                        ds.Add(a);
                        break;
                    case 3:
                        Nhommau b = new B();
                        b.nhap();
                        ds.Add(b);
                        break;
                    case 4:
                        Nhommau ab = new AB();
                        ab.nhap();
                        ds.Add(ab);
                        break;
                    case 0:
                    
                        break;
                }
            }
        }
        public void cau2()
        {
            Nhommau cha = new A();
            Nhommau me = new B();
            Nhommau con = new O();
            if (con.checkDiTruyen(cha,me))
            {
                Console.WriteLine("3 người phù hợp di truyền");
            }
            else Console.WriteLine("3 người không phù hợp di truyền");
        }
        public void cau3()
        {
            int viTri;
            Console.WriteLine("Nhập vị trí x trong danh sách: ");
            viTri = int.Parse(Console.ReadLine());
            for(int i = 0; i < ds.Count; i++)
            {
                if(i != viTri && (ds[viTri].checkChoNhan(ds[1])) == true)
                {
                    Console.WriteLine($"Người {i+1} phù hợp cho máu");
                }
            }
        }
    }
}
