using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.73 б
            double s = 100;
            double u = 20;
            double v = s * u;
            for (int i =2 ; i <= 7; i = i + 1)
            {
                s = s + s / 100.0 * 5;
                u = u + u / 100.0 * 2;
                v = s * u;
                if (i >= 4)
                {
                    Console.WriteLine(s);
                }
                
            }
            Console.ReadKey();
        }
    }
}
