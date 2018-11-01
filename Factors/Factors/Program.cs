using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.WriteLine("Enter tha number : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Tha factors are : ");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();


            }

        }
    }
}
