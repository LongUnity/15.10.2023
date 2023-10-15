using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /*
            try
            {
                int b = int.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);//chạy khi bắt được lỗi xảy ra
            }*/

            int x = 10;
            int y=0;
            int z = 0;

            try
            {
                z = x / y;
            }
            catch(DivideByZeroException e1) 
            {
                Console.WriteLine(e1.Message);
            }
            finally
            {
                Console.WriteLine(z);
            }


            Console.ReadKey();

        }
    }
}
