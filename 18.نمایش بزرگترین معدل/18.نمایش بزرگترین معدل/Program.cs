using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.نمایش_بزرگترین_معدل
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = Int32.Parse(Console.ReadLine());
            int counter = 2;
            while(counter<=5)
            {
                int num = Int32.Parse(Console.ReadLine());
                if (num == 0)
                    continue;
                if (num > max)
                    max = num;
                counter++;
            }
            Console.Write("maximom moadel:"+max);
            Console.ReadKey();
        }
    }
}
