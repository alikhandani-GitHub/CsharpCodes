using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37.نمایش_محاسبه_فاکتوریل_به_روش_بازگشتی
{
    class Program
    {
        static long factorial(int number)
        {
            if (number == 1)
                return 1;           
            return number * factorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadKey();
        }
    }
}
