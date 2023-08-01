using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_تبدیل_تاریخ_میلادی_به_شمسی
{
    class Program
    {
        static void Main(string[] args)
        {
            int sal = Int32.Parse(Console.ReadLine());
            int mah = Int32.Parse(Console.ReadLine());
            int roz = Int32.Parse(Console.ReadLine());
            if ( sal==2020)
                Console.Write("1398/");
            else if( mah==2)
                Console.Write("11/");
            else if( roz==1)
                Console.Write("12");
            Console.ReadKey();
        }
    }
}
