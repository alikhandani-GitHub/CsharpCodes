using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgect1400
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Ali welcome in Programmer");
            Console.Write("please enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter name: ");
            String name = Console.ReadLine();
            //Console.WriteLine("num is: " + number);
            //myMethod();
            //myMethod2();
            //myClass myClass = new myClass();
            int show = myClass.numberMethod(number);
            String show2 = myClass.nameMethod(name);
            Console.WriteLine("number is: " + show);
            Console.WriteLine("name is: " + show2);
            for (int i = 0; i <= number; i++)
            {
                show = i;
                Console.WriteLine(i);
            }
            Console.WriteLine("///////////");
            Console.WriteLine(show);
            Console.ReadKey();
        }

        static void myMethod()
        {
            Console.WriteLine("myMethod");

        }

        static void myMethod2()
        {
            Console.WriteLine("myMethod2");
        }
    }
}
