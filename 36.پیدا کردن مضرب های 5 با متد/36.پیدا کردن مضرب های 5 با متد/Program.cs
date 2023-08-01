using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36.پیدا_کردن_مضرب_های_5_با_متد
{
    class Program
    {
        static void getinput(out int x, out int y)
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
        }
        static void SwapIfalsGreater(ref int x, ref int y)
        {
            if (x > y)
            {
                int t = x;
                x = y;
                y = t;
            }
        }       
        static void first5factor(ref int x)
        {
            while (x % 5 != 0)
                x++;
        }
        static void show5factor(int a, int b)
        {
            for (int i = 0; i <= b; i += 5)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            int a, b;
            getinput(out a, out b);
            SwapIfalsGreater(ref a, ref b);
            first5factor(ref a);
            show5factor(a, b);
            Console.ReadKey();
        }
    }
}