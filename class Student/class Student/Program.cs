using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Student
{
    class Student
    {
        public string Name;
        public string[] courseName = new string[5] { "reyazi", "fizik", "shimi", "zaban", "tarikh" };
        public int[] Coursemark=new int[5] { 16, 28, 20, 19, 20 };

        public Student()//به جای voidاز این اجراش میکنی نام میگیره
        {
            Console.Write("lotfan name ra vared konid: ");
            Name = Console.ReadLine();             
            for(int i=0;i<=courseName.Length;i++)
            {
                Console.Write("\nName of course {0}:", i + 1);
                    courseName[i] = Console.ReadLine();
                Console.Write("mark of {0}:", courseName[i]);
                Coursemark[i] = Int32.Parse(Console.ReadLine());
            }
        }
        public int Maxnomre()
        {
            int max = Coursemark[0];
            for (int i = 1; i < Coursemark.Length; i++)
                if (Coursemark[i] > max)
                    max = Coursemark[i];
            return max;
        }
        public int Minnomre()
        {
            int min = Coursemark[0];
            for (int j = 1; j < Coursemark.Length; j++)            
                if (Coursemark[j] < min)
                    min = Coursemark[j];            
                return min;            
        }
        public void Sortmark()
        {
            for (int i = 0; i < Coursemark.Length - i; i++)
                for (int j = 0; j < Coursemark.Length - 1 - i; j++)
                    if (Coursemark[j] > Coursemark[j + 1])
                    {
                        int temp = Coursemark[j];
                        Coursemark[j] = Coursemark[j + 1];
                        Coursemark[j + 1] = temp;
                    }
            

        }
        public void Showmark()
        {
            for (int i = 0; i < Coursemark.Length; i++)
                Console.WriteLine("{0}  {1}  {2}",i+1,courseName[i],Coursemark[i]);
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student n = new Student();
            //n.Get();
            n.Showmark();
            n.Sortmark();
            Console.WriteLine();
            n.Showmark();
            Console.Write("maxiom :  ");
            Console.WriteLine(n.Maxnomre());
            Console.Write("minimom:  ");
            Console.WriteLine(n.Minnomre());
            //n.Showmark();
            //n.courseName[0].Substring(0, 1);برای ترتیب حروف
            Console.ReadKey();
        }
    }
}
