using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15نمایش_ارقام_به_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = 0;
            while(a>0)
            {
                a /= 10;
                b++;
            }
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
