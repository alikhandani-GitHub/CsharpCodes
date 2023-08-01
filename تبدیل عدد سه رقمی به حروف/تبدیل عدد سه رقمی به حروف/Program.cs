using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تبدیل_عدد_سه_رقمی_به_حروف
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your number:");
            int a = Int32.Parse(Console.ReadLine());
            int b = a / 100;
            int c = (a % 100) / 10;
            int d = (a % 100) % 10;
            switch (b)
            {
                case 1:
                    Console.Write("One Hundred ");
                    break;
                case 2:
                    Console.Write("Two Hundred ");
                    break;
                case 3:
                    Console.Write("Three Hundred ");
                    break;
                case 4:
                    Console.Write("Fure Hundred ");
                    break;
                case 5:
                    Console.Write("Five Hundred ");
                    break;
                case 6:
                    Console.Write("Six Hundred ");
                    break;
                case 7:
                    Console.Write("Seven Hundred ");
                    break;
                case 8:
                    Console.Write("Eight Hundred ");
                    break;
                case 9:
                    Console.Write("Nine Hundred ");
                    break;
            }
            if (c == 1)
                switch (d)
                {
                    case 0:
                        Console.Write("Ten ");
                        break;
                    case 1:
                        Console.Write("Eleven ");
                        break;
                    case 2:
                        Console.Write("Twelve ");
                        break;
                    case 3:
                        Console.Write("Thirteen ");
                        break;
                    case 4:
                        Console.Write("Fourteen ");
                        break;
                    case 5:
                        Console.Write("Fifteen ");
                        break;
                    case 6:
                        Console.Write("Sixteen ");
                        break;
                    case 7:
                        Console.Write("Seventeen ");
                        break;
                    case 8:
                        Console.Write("Eighteen ");
                        break;
                    case 9:
                        Console.Write("Nineteen ");
                        break;
                }
            else
            {
                switch (c)
                {
                    case 2:
                        Console.Write("Twenty ");
                        break;
                    case 3:
                        Console.Write("Thirty ");
                        break;
                    case 4:
                        Console.Write("Fourty ");
                        break;
                    case 5:
                        Console.Write("Fifty ");
                        break;
                    case 6:
                        Console.Write("Sixty ");
                        break;
                    case 7:
                        Console.Write("Seventy ");
                        break;
                    case 8:
                        Console.Write("Eighty ");
                        break;
                    case 9:
                        Console.Write("Ninety ");
                        break;
                }
                switch (d)
                {
                    case 1:
                        Console.Write("One");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                }

            }
            Console.ReadKey();
        }
    }
}
