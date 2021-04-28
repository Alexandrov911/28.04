using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.89
            Console.WriteLine("Введите колличество слагаемых");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                int f = 1;
                for (int j = 1; j<= i; j=j+1)
                {
                    f = f * j;
                }
                s = s + f;

            }
            Console.WriteLine(s);
            Console.ReadKey();
               
           

        }
    }
}
