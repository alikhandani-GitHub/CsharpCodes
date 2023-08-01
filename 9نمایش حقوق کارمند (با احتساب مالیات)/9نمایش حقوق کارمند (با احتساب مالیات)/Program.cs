using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9نمایش_حقوق_کارمند__با_احتساب_مالیات_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("lotfan hoghogh ra vared konid: ");
            int hoghogh = Int32.Parse(Console.ReadLine());
            if (hoghogh < 1000)
                Console.WriteLine("moaf az maliyat");
            else if (hoghogh >= 1000 && hoghogh < 2000)
            {
                int maliat = (hoghogh * 2) / 100;
                hoghogh = hoghogh - maliat;
                Console.WriteLine(hoghogh);
            }
            else if (hoghogh >= 2000 && hoghogh < 3000)
            {
                int maliat = (hoghogh * 5) / 100;
                hoghogh = hoghogh - maliat;
                Console.WriteLine(hoghogh);
            }
            else if (hoghogh >= 3000)
            {
               int maliat = (hoghogh * 10) / 100;
                hoghogh = hoghogh - maliat;
                Console.WriteLine(hoghogh);
            }
            Console.ReadKey();
        }

    }
}
