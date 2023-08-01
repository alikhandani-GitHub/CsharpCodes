using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberClass
{
    public class Number
    {
        public int num;
        public Number()
        {
            Console.Write("enter a number: ");
            num = Int32.Parse(Console.ReadLine());
        }
        ~Number()
        {
            Console.WriteLine("Ali Khandani");
            Console.ReadKey();
        }
        public string OddorEven()
        {
            if (num % 2 == 0)
                return "Even";
            else
                return "Odd";
        }
    }
}
