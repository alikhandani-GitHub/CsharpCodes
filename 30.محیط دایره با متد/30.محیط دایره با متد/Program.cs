using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30.محیط_دایره_با_متد
{
    class Program
    {
        static double mohit(double num)
        {
            double m = num * 2 * 3.14;
            return m;
        }
        static void Main(string[] args)
        {
                double a, b;
                 a = Int32.Parse(Console.ReadLine());
                b = mohit(a);
                Console.Write(b);
                Console.ReadKey();
        }
    }
}
