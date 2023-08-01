using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    class number
    {
        public int num;
        public number()
        {
            Console.Write("enter a number");
            num = Int32.Parse(Console.ReadLine());
        }
        public string OddorEven()
        {
            if (num % 2 == 0)
                return "zoj";
            else
                return "fard";
        }
    }
}
