using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            byte number2;
            number2 = Convert.ToByte(number1);
            Console.WriteLine(number2);
            Console.ReadKey();

        }
    }
}
