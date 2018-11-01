using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeriesRecurtion
{
    class Program
    {
       static int FibonacciSeries(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
         static void Main(string[] args )
        {
            
            Console.WriteLine("Enter the length of the Fibonacci Series: ");
            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write( "{0} ",FibonacciSeries(i));

            }
            Console.ReadKey();

        }
    }
}
