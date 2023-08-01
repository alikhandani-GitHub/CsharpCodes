using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.دریافت_10_عدد_و_نمایش_برعکس_ان
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] a= new int[10];
            for (i = 0; i <a.Length; i++)
                 a[i] = Int32.Parse(Console.ReadLine());
            for (i = 9; i >= 0; i--)
                Console.WriteLine(a[i]);
            Console.ReadKey();
        }//length mins SIZE arry
    }
}
