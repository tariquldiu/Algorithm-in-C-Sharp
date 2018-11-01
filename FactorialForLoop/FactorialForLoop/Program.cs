using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, num, fact;
            Console.WriteLine("Enter tha number : ");
            num = int.Parse(Console.ReadLine());
            fact = num;
            for (i = num-1; i >= 1; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial of tha number is: " );
            Console.WriteLine(fact);
            Console.ReadKey();
        }
    }
}
