using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10سن_و_وزن_و_قد_ونمایش_چاق_یا_لاغر
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PLEAS weight and height enter: ");
            int weight = Int32.Parse(Console.ReadLine());
            double height = Double.Parse(Console.ReadLine());
            double BMI = weight / (height * height);
            Console.Write(BMI);
            if (BMI <= 18.5)
                Console.Write("kambod vazn besyar shadid ");
            else if (BMI >= 18 || BMI <= 24.9)
                Console.Write("tabie ");
            else if (BMI >= 25 || BMI <= 29.9)
                Console.Write("ezafe vazn");
            else if (BMI >= 30)
                Console.Write("chagh");
            Console.ReadKey();
        }
    }
}
