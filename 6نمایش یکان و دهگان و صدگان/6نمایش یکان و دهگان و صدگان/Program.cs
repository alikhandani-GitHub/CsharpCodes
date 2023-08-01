using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6نمایش_یکان_و_دهگان_و_صدگان
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int a, b, c, m;
            a = num / 100;
            b = num % 100;
            c = b / 10;
            m = b % 10;
            Console.WriteLine(b);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
