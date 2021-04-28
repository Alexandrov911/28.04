using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.72 б
            double s = 10;
            double sum = s;
            for (int i = 2; i <= 7; i = i + 1)
            {
                s = s + s / 100.0 * 10;
                sum = sum + s;
                
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
