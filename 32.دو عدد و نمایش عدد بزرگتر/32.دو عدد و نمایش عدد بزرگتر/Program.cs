using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.دو_عدد_و_نمایش_عدد_بزرگتر
{
    class Program
    {
        static int maxx (int a , int b)
        {
            if (a > b)
                return a;
            else if (a == b)
                return 0;
            else
                return b;
        }
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(maxx(num1,num2));
            Console.ReadKey();
        }
    }
}
