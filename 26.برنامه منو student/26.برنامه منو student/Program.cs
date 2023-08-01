using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.برنامه_منو_student
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0;
            string[] name = new string[20];
            long[] code = new long[10];
            double[] nomre = new double[5];
            Console.WriteLine("1) New student");
            Console.WriteLine("2) Delit studen ");
            Console.WriteLine("3) Search a student ");
            Console.WriteLine("4) List of student ");
            Console.WriteLine("5) Exit ");
            while (true)
            {
                int num = Int32.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("1) New student");
                    Console.Write("lotfan nam ra vared konid:");
                    name[i] = Console.ReadLine();
                    Console.Write("lotfan code ra vared konid:");
                    code[i] = Int64.Parse(Console.ReadLine());
                    i++;
                }
                else if (num == 2)

                    Console.WriteLine("2) Delit studen ");

                else if (num == 3)

                    Console.WriteLine("3) Search a student ");

                else if (num == 4)
                {
                    Console.WriteLine("4) List of student ");
                    for (j = 0; j < i; j++)
                        Console.WriteLine("{0}   {1}", name[j], code[j]);
                }
                else if (num == 5)

                    Console.WriteLine("5) Exit ");
                else
                    Console.WriteLine("***Error***");

            }
            Console.ReadKey();
        }
    }
}
