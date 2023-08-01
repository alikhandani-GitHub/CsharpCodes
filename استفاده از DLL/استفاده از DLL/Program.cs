using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumberClass;

namespace استفاده_از_DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            Number n = new Number();
            Console.Write(n.OddorEven());
        }
    }
}
