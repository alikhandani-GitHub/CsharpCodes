using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31.طول_و_عرض_مستطیل_با_متد
{
    class Program
    {
        static int masahat(int num1, int num2)
        {
            int c = num1 * num2;
            return c;
        }
        static int mohit (int num1 , int num2)
        {
            return (num1 + num2) * 2;
        }


        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int ma =masahat (a , b);
            int moh = mohit(a, b);
            Console.WriteLine(ma);
            Console.WriteLine(moh);
            Console.ReadKey();

        }
    }
}
