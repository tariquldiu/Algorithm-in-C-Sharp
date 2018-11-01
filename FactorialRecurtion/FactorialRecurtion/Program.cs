using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecurtion
{
    class Program
    {
      
        static void Main(string[] args)
        {
            int n, fact;
            Console.WriteLine("Enter tha number: ");
            n = int.Parse(Console.ReadLine());
            fact = factarial(n);
            Console.WriteLine("Tha factarial number is :"+ fact);
            Console.ReadKey();
        }
        public static int factarial(int m)
        {
            if (m <= 1)
            {
                return 1;
            }
            else
                return m * factarial(m - 1);
        }
 

    }
}
