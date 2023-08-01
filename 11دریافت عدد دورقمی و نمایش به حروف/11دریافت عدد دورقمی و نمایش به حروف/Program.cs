using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11دریافت_عدد_دورقمی_و_نمایش_به_حروف
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lotfan yek adad vared konid: ");
            int num = Int32.Parse(Console.ReadLine());
            int a = num % 10;
            num = num / 10;
            if (num == 1)
                Console.Write("yek");
            else if (num == 2)
                Console.Write("do");
            else if (num == 3)
                Console.Write("ce");
            else if (num == 4)
                Console.Write("chahar");
            else if (num == 5)
                Console.Write("panj");
            else if (num == 6)
                Console.Write("shish");
            else if (num == 7)
                Console.Write("haft");
            else if (num == 8)
                Console.Write("hasht");
            else if (num == 9)
                Console.Write("noh");
            if (a == 1)
                Console.Write("yek");
            else if (a == 2)
                Console.Write("do");
            else if (a == 3)
                Console.Write("ce");
            else if (a == 4)
                Console.Write("chahar");
            else if (a == 5)
                Console.Write("panj");
            else if (a == 6)
                Console.Write("shish");
            else if (a == 7)
                Console.Write("haft");
            else if (a == 8)
                Console.Write("hasht");
            else if (a == 9)
                Console.Write("noh");
            Console.ReadKey();
        }
    }
}
