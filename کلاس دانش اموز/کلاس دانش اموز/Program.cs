using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace کلاس_دانش_اموز
{
    class Student
    {
        double[] mark = new double[5];
        public Student()
        {
            for (int i = 0; i < 5; i++)
                mark[i] = double.Parse(Console.ReadLine());
        }
         ~Student()//مخرب c
        {
            Console.WriteLine("good by");
        }   
        public double average()
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
                sum += mark[i];
            return sum / 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.Write("Moadel:");
            Console.Write(s.average());
            Console.ReadKey();
        }
    }
}
