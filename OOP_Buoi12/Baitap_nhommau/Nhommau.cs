using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_nhommau
{
    internal abstract class Nhommau
    {
        public int Loaimau { get; set; }
        public const int _O = 1;
        public const int _A = 2;
        public const int _B = 3;
        public const int _AB = 4;
        public bool RH { get; set; }
        public Nhommau() { }

        public void nhap()
        {
            Console.WriteLine("RH+/RH-:");
            Console.WriteLine("1.RH+");
            Console.WriteLine("2.RH-");
            int n= int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1:
                    RH = true;
                    break;
                case 2:
                    RH = false;
                    break;
            }
        }
        public bool checkDiTruyen(Nhommau cha, Nhommau me)
        {
            if (cha.Loaimau == _A)
            {
                if (me.Loaimau == _O || me.Loaimau == _A)
                {
                    if (Loaimau == _O || Loaimau == _A)
                    {
                        return true;
                    }
                }
                else if (me.Loaimau == _B)
                {
                    return true;
                }
                else if (me.Loaimau == _AB)
                {
                    if (Loaimau != _O)
                    {
                        return true;
                    }
                }
            }
            else if (cha.Loaimau == _B)
            {
                if (me.Loaimau == _A)
                {
                    return true;
                }
                else if (me.Loaimau == _B || me.Loaimau == _O)
                {
                    if (Loaimau == _B || Loaimau == _O)
                    {
                        return true;
                    }
                }
                else if (me.Loaimau == _AB)
                {
                    if (Loaimau != _O)
                    {
                        return true;
                    }
                }
            }
            else if (cha.Loaimau == _AB)
            {
                if (me.Loaimau == _A || me.Loaimau == _B)
                {
                    return true;
                }
                else if (me.Loaimau != _O)
                {
                    if (Loaimau != _O)
                    {
                        return true;
                    }
                }
            }
            else if (cha.Loaimau == _O)
            {
                if (me.Loaimau == _A)
                {
                    if (Loaimau == _A || Loaimau == _O)
                    {
                        return true;
                    }
                }
                else if (me.Loaimau == _B)
                {
                    if (Loaimau == _B || Loaimau == _O)
                    {
                        return true;
                    }
                }
                else if (me.Loaimau == _AB)
                {
                    if (Loaimau == _A || Loaimau == _B)
                    {
                        return true;
                    }
                }
            }
            return false; 
        }        
        public abstract bool checkChoNhan(Nhommau cho);
    }
}
