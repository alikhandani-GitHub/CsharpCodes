using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members
{
    class Number
    {
        public static int num;
        public static int factoril()
        {
            int fact = 1;
            for (int i = 1; i <= num; i++)
                fact *= i;
            return fact;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number.num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Number.factoril());
            Console.ReadKey();
        }
    }
}
