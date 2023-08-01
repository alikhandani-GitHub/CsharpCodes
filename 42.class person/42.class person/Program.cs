using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42.class_person
{
    class person
    {
        public string[] Name = new string[20];
        public int Age;
        public int Height;
        public int Weight;
        public int ShowDays()
        {
            return Age * 365;
        }
        public int ShowMonth()
        {
            return Age * 12;
        }
        public string IsFat()
        {
            if (Height >= 150 && Weight <= 50)
                return "laghar";
            else if (Height <= 120 && Weight >= 80)
                return "chagh";
            else
                return "tabiei";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            person n = new person();
            Console.Write("lotfn name ra vared konid: ");
            n.Name[i] = Console.ReadLine();
            Console.Write("lotfan age ra vared konid: ");
            n.Age = Int32.Parse(Console.ReadLine());
            Console.Write("lotfan ghad ra vared konid: ");
            n.Height = Int32.Parse(Console.ReadLine());
            Console.Write("lotfan vazn ra vared konid: ");
            n.Weight = Int32.Parse(Console.ReadLine());
            Console.Write("roz: ");
            Console.WriteLine(n.ShowDays());
            Console.Write("mah: ");
            Console.WriteLine(n.ShowMonth());
            Console.Write("Is Fat: ");
            Console.WriteLine(n.IsFat());
            Console.ReadKey();
        }
    }
}
