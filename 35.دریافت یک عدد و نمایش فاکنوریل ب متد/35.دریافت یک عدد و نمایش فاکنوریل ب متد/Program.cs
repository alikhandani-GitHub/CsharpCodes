using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.دریافت_یک_عدد_و_نمایش_فاکنوریل_ب_متد
{
    class Program
    {
        static int fctor(int n)
        {
            int fact=1, i;
            for (i = 1; i <= n; ++i)
            {
                fact = fact * i;
            }
            return fact;

        }

        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int b = fctor(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
