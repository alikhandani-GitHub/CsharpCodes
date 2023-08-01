using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_test03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            String name2 = Console.ReadLine();
            Console.WriteLine("Enter a size array: ");
            int num = Convert.ToInt32(Console.ReadLine());          
            int[] array1 = new int[num];
            int[] array2 = new int[num];
            int[] sum = new int[num];
            int i = 0;
            Console.WriteLine("Enter elment array1:");
            for (i = 0; i < num; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter elment arrat2:");
            for (i = 0; i < num; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("****** Result ******");
            Console.WriteLine(name.ToUpper());        
            //Console.WriteLine(name.Insert(2,name2));        
            //Console.WriteLine(name.Replace('a','r'));        
            //Console.WriteLine(name.Split());
            //Console.WriteLine(name.Clone());
            //Console.WriteLine(name.CompareTo(name2));
            //Console.WriteLine(name.GetHashCode());
            Console.WriteLine("sum of arrays:");
            for (i = 0; i < num; i++)            
                sum[i] = array1[i] + array2[i];                       
            for (i = 0; i < num; i++)
                Console.Write(sum[i] + "\t");
            Console.WriteLine();
            Console.WriteLine("multi of arrays:");
            for (i = 0; i < num; i++)            
                sum[i] = array1[i] * array2[i];                            
            for (i = 0; i < num; i++)
                Console.Write(sum[i] + "\t");           
            Console.WriteLine();
            Console.WriteLine("maxii in array1:");
            int maxii = array1[0];
            for (i = 0; i < num; i++)
                if (array1[i] > maxii)
                    maxii = array1[i];
            Console.WriteLine(maxii);
            Console.WriteLine();           
            Console.WriteLine("maxii in array2:");
            int maxii2 = array2[0];
            for (i = 0; i < num; i++)
                if (array2[i] > maxii2)
                    maxii2 = array2[i];
            Console.WriteLine(maxii2);
            Console.ReadKey();
        }
    }
}
