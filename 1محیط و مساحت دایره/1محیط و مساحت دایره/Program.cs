using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1محیط_و_مساحت_دایره
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lotfan adad ra vred konid: ");
            int num = Int32.Parse(Console.ReadLine());
            double m = num*2*3.14;
            double c = 3.14 *num*num;
            Console.WriteLine("mohit is{0}and masahat is{1}", m, c);
            /*Console.WriteLine(m);
            Console.WriteLine(c);*/
            Console.ReadKey();
        }
    }
}
