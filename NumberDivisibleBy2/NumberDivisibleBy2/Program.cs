using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberDivisibleBy2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter tha number: ");
            n = int.Parse(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("Tha number is divisible by 2.");
            }
            else
            {
                Console.WriteLine("Tha number is not divisiable by 2.");
            }
            Console.ReadKey();
        }
    }
}
