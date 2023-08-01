using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تمرین_وراثت
{
    class Rectangle
    {
        public int Width;
        public int height;
        public int AreaCalculate()
        {
            return Width * height;
        }
        class Square:Rectangle
        {
            public Square(int side)
            {
                height = Width = side;
            }

        }
        class program
        {
            static void Main(string[] args)
            {
                Square sq = new Square(5);
                Console.WriteLine(sq.AreaCalculate());
                Console.ReadKey();
            }
        }  
     
        
    }
}
