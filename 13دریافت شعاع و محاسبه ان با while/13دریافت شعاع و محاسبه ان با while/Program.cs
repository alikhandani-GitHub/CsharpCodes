using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13دریافت_شعاع_و_محاسبه_ان_با_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int shoah = Int32.Parse(Console.ReadLine());
            while(shoah<0)
            {
                Console.WriteLine("dar sorat shah namotabar bobare daryaft shavad.");
                shoah = Int32.Parse(Console.ReadLine());
            }
            Console.Write(2 * 3.14 * shoah);
            Console.ReadKey();
        
        }
    }
}
