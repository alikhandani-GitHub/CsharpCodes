using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.عدد_تام
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for(int num=1;num<10000;num++)
            {
                int sum = 0;
                for (int i = 1; i < num; i++)                
                    if (num % i == 0)
                        sum = sum + i;
                    if (sum == num)
                        Console.WriteLine(num);                
            }
            Console.ReadKey();
           
        }
    }
}
