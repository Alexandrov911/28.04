using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.73 а
            double s = 100;
            double u = 20;
            double v = s * u;
            for (int i = 1; i <= 8; i = i + 1)
            {
                s = s + s / 100.0 * 5;
                u = u + u / 100.0 * 2;
                v = s * u;
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
