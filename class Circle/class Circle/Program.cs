using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Circle
{
    class Circle
    {
        int radius;
        public int GetRadius()
        {
            radius = Int32.Parse(Console.ReadLine());
            return 0;
        }
        public double CircumferenceCalculate()
        {
            return (radius * radius) * 3.14;
        }
        public double AreaCalculate()
        {
            return (radius * 2) * 3.14;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Console.WriteLine(c.GetRadius());
            Console.Write("masahat: ");
            Console.WriteLine(c.CircumferenceCalculate());
            Console.Write("mohit: ");
            Console.WriteLine(c.AreaCalculate());
            Console.ReadKey();
        }
    }
}
