using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.ورود_و_خروج_با_متد
{
    class Program
    {
        static int SquareCalculate(int a)
        {
            int b = a * a;
            return b;
        }
        static void Main(string[] args)
        {
            int x, y;
            x = Int32.Parse(Console.ReadLine());
            y = SquareCalculate(x);
            Console.Write(y);
            Console.ReadKey();
        }
    }
}
