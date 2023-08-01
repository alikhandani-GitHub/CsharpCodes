using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39.دو_عدد_و_به_توان_رساندن_اولی_در_دومی
{
    class Program
    {
        static int power(int a,int b)
        {
            if(b>1)
            {
                return (a * power(a, b - 1));
            }
            else
            {
                return a;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
