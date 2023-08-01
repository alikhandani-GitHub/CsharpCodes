using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41.class_numberشی_گرایی
{
    class number
    {
        public int num;
        public string OddorEven()
        {
            if (num % 2 == 0)
                return "zoj";
            else
                return"fard";
        }
        public int Squere()
        {
            return num * num;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            number n = new number();
            Console.WriteLine("lotfan adad mosbat vared konid: ");
            n.num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(n.OddorEven());
            Console.WriteLine(n.Squere());
            Console.ReadKey();
        }
    }
}
