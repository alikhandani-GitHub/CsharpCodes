using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4سال_کبیسه
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            int b = a * 365 ;
            int c = b % 4;
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
