using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40.تبدیل_انواع_شمارشی
{
    class Program
    {
        enum Direction//enum برای شمارش است
        {
            North,East,South,West
        }
        static void Main(string[] args)
        {
            Direction myDirection = Direction.East;
            int mydirectioncode = (int)myDirection;
            Console.WriteLine("value of East is {0}", mydirectioncode);
            myDirection = (Direction)3;
            Console.WriteLine("Direction: {0}",myDirection);
            Console.ReadKey();
        }
    }
}
