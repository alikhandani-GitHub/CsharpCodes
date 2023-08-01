using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_test02
{
    class Program
    {
        static void Main(string[] args)
        {
            Univercity univercity = new Univercity();
            List<Univercity> univercities = new List<Univercity>();
            List<double> grd = new List<double>();
            List<String> nam = new List<String>();          
            double avg = 0.0;
            Console.WriteLine("Number of Students:");
            int num = Convert.ToInt32(Console.ReadLine());          
            for (int i = 0; i < num; i++)
            {               
                double gr = Convert.ToDouble(Console.ReadLine());
                grd.Add(gr);                
            }
            foreach(double grde in grd)
            {
                avg += grde;
                avg /= (double) num;
                Console.WriteLine(avg);
            }            
            Console.ReadKey();
        }
    }
}
