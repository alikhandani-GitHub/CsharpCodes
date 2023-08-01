using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.عدد_اول
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            int i = 2;
            while(i<num)
            {
                if (num % i == 0)
                    break;
                i++;
            }
            if (i == num)
                Console.Write("YES");
            else
                Console.Write("NO");
            Console.ReadKey();
        }
    }
}
