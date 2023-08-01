using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.تشخیص_زوج_یا_فرد_بودن_با_متد
{
    class Program
    {
        static string adad(int mynum)
        {
            if (mynum % 2 == 0)
                return "zoj";
            else
                return "fard";
        }
        static void Main(string[] args)
        {
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(adad(num));
            Console.ReadKey();
        }
    }
}
