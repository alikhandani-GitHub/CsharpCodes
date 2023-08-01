using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38.ضرب_اعداد_با_جمع_اعدادمتوالی
{
    class Program
    {
        static int myzarb(int n1, int n2)
        {
            // if (n1 == 1)
            //   return n2;
            //return n2 + myzarb(n1 - 1, n2);
            int sum = 0;
            for (int i = 1; i <= n2; i++)
                sum += n1;
            return sum;
        }
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine(myzarb(num1, num2));
            Console.ReadKey();
        }
    }
}
