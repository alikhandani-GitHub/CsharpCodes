using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_شعاع_ومساحت
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = (a * b) + 2;
            int d = a * b;
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.ReadKey();

        }
    }
}
