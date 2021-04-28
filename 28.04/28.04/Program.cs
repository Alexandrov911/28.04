using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.72 a
            double s = 10;
            for (int i = 2; i <= 10; i = i + 1)
            {
                s = s+s / 100.0 * 10;
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
