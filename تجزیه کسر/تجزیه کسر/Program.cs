using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تجزیه_کسر
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, j = 0, k = 0, num1 = 0, num2 = 0;
            int[] myarry = new int[100];
            double[] ashari = new double[100];
            char index;
            while (num1 != 0 && num2 != 0)
            {
                num1 = Int32.Parse(Console.ReadLine());
                index = Char.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());
                if (num1 == 0 && num2 == 0)
                    break;
                myarry[i] = num1;
                i++;
                myarry[i] = num2;
                i++;
                ashari[j] = num1 / num2;
            }
            i = 0;
            i--;
            k = i;
            j = 0;
            for (; i <= k; j++, i += 2)
            {
                Console.Write(myarry[i]+"="+ myarry[i + 1]+"="+ashari[j]);               
            }
            Console.ReadKey();
        }
    }
}
