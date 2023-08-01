using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3سن_کاربر_و_روزها_و_ماهای_عمر
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b;
            int c;
            b = a * 365;
            c = a * 12;
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
