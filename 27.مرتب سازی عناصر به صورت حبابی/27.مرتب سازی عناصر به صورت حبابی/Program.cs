using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27.مرتب_سازی_عناصر_به_صورت_حبابی
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, t;
            int[] a = new int[10];
            for (i = 0; i < 10; i++)
                a[i] = Int32.Parse(Console.ReadLine());
            for(i=0;i<9;i++)
                for(j=0;j<9-i;j++)
                    if(a[j]>a[j+1])
                    { t = a[j];a[j] = a[j + 1];a[j + 1] = t; }
            for (i = 0; i < 10; i++)            
                Console.WriteLine(a[i]);
            Console.ReadKey();
        }
    }
}
