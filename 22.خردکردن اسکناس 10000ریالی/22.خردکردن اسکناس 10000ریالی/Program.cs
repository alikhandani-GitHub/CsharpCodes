using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.خردکردن_اسکناس_10000ریالی
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i1=0;i1<=10;i1++)
            {

                for (int i2 = 0; i1 <= 5; i2++)
                {
                    for (int i5 = 0; i5 <= 2; i5++)
                    
                        if (i1 * 1000 + i2 * 2000 + i5 * 5000 == 10000)
                            Console.Write("{0}{1}{2}", i1, i2, i5);
                    
                }

            }
                
            Console.ReadKey();
        }
    }
}
