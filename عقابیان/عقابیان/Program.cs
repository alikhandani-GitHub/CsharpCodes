using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace عقابیان
{
    class number
    {
        public int num;
        public string OddOrEven()
        {
            if (num % 2 == 0)
                return "Even";
            return "Odd";
        }
        public int Squere()
        {
            return num * num;
        }
        public string PrimeNumber()
        {
            int i = 2;
            while (i < num)
            {
                if (num % i == 0)
                    break;
                i++;
            }
            if (num == i)
                return "YES";
            return "NO";
        }
        public string AddTom()
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
                if (num % i == 0)
                    sum += i;
            if (sum == num)
                return "YES";
            return "NO";
        }
        public int Maghlob()
        {
            int reverse = 0;
            for (int i = 0; num > 0; i++)
            {
                int j = num % 10;
                reverse *= 10;
                reverse += j;

                num /= 10;
            }
            return reverse;
            /*while (num > 0)
            {
                return num % 10;
                num = num / 10;
            }*/

        }
        public int Argham()
        {
            if (num > 0)
            {
                int a = num % 10;
                int b = num / 10;
                return a;
                return b;
            }
            else
                return 0;
        }
        public int MaghsomEleayh()
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    Console.WriteLine(i);
            }
            return 0;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            number n = new number();
            n.num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(n.OddOrEven());
            Console.WriteLine(n.Squere());
            Console.WriteLine(n.PrimeNumber());
            Console.WriteLine(n.AddTom());
            Console.WriteLine(n.Maghlob());
            Console.WriteLine(n.Argham());
            Console.WriteLine(n.MaghsomEleayh());
            Console.ReadKey();
        }
    }
}
       
    

