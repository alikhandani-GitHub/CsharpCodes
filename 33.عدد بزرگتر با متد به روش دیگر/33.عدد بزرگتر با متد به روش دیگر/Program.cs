using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33.عدد_بزرگتر_با_متد_به_روش_دیگر
{
    class Program
    {
        static void showmax(int num1 , int num2)
        {
            if (num1 > num2)
                Console.WriteLine("max ="+num1);
            else if (num1 == num2)
                Console.WriteLine("aedad mosavi hastand");
            else
                Console.WriteLine("max ={0}",num2);
        }
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            showmax(a , b);
            Console.ReadKey();
        }
    }
}
