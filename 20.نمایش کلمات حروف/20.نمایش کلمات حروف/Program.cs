using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.نمایش_کلمات_حروف
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int char = 'a', int x = 0; char != '.')
                if ((char = Console.ReadKey()) == '')
                    x++;
            Console.Write(++x);
        }
    }
}
