using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.نمایش_معدل_10_دانشجو
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            int[] a = new int[10];
            string[] n = new string[10];
            Console.Write("enter name of cours{0}:", i++);
            Console.Write("enter mark of {0}:", n[i]);
            for (i = 0; i < a.Length; i++)
            {
                Console.Write("nam dars {0}:",i);
                n[i] = Console.ReadLine();
                Console.Write("nomre dars");
                a[i] = Int32.Parse(Console.ReadLine());
            }
            for (i = 0; i < a.Length; i++)
                sum+= a[i];
            for (i = 0; i < a.Length; i++)
                Console.WriteLine(a[i]);
            Console.WriteLine(sum / 10);
            Console.ReadKey();
        }
    }
}
