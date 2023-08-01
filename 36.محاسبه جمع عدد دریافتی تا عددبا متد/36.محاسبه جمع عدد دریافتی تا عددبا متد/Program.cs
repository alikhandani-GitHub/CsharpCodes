using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.محاسبه_جمع_عدد_دریافتی_تا_عددبا_متد
{
    class Program
    {
        static int mysum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
                sum += i;
            return sum;
        }
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(mysum(num));
            Console.ReadKey();
        }
    }
}
