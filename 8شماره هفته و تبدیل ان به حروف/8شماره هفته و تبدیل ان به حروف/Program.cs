using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8شماره_هفته_و_تبدیل_ان_به_حروف
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = Int32.Parse(Console.ReadLine());
            if (day == 1)
                Console.WriteLine("shanbe");
            else if (day == 2)
                Console.WriteLine("yek shanbe");
            else if (day == 3)
                Console.WriteLine("do shanbe");
            else if (day == 4)
                Console.WriteLine("se shanbe");
            else if (day == 5)
                Console.WriteLine("chahar shanbe");
            else if (day == 6)
                Console.WriteLine("panj shanbe");
            else if (day == 7)
                Console.WriteLine("jome");
            Console.ReadKey();
        }
    }
}
