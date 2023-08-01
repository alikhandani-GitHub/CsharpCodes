using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7تعداد_ثانیه_گذشته
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int b = num / 3600;
            int c = (num % 3600)/60;
            int d = (num % 3600) % 60;
            // Console.Write("Time is {0}:{1}:{2}",b,c,d);
            Console.Write("Time is" + b + ":" + c + ":" + d);
            Console.ReadKey();
        }
    }
}
