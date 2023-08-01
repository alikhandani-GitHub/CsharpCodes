using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43.Rectangle_Class
{
    class Rectangle
    {
        public int Height;
        public int Width;
        public int CircumferenceCalculate()
        {
            return Height * Width;
        }
        public int AreaCalculate()
        {
            return (Width + Height) * 2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.Write("lotfan width ra vared konid: ");
            r.Width = Int32.Parse(Console.ReadLine());
            Console.Write("lotfan height ra vared konid: ");
            r.Height = Int32.Parse(Console.ReadLine());
            Console.Write("masahat: ");
            Console.WriteLine(r.CircumferenceCalculate());
            Console.Write("mohit: ");
            Console.WriteLine(r.AreaCalculate());
            Console.ReadKey();

        }
    }
}
