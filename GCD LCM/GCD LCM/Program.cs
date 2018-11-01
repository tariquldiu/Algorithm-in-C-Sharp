using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCD_LCM
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Program for GCD & LCM : ");
            Console.WriteLine("Enter tha 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter tha 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int gcd = GCD(a, b);
            int lcm = LCM(a, b);
            Console.WriteLine("\n"+gcd);
            Console.WriteLine("\n"+lcm);
            Console.ReadKey();
        }

        public static int GCD(int num1, int num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;

                if (num2 > num1)
                    num2 = num2 - num1;
            }
                return num1;           

        }
        public static int LCM(int num1, int num2)
        {
            return (num1*num2)/GCD(num1,num2);
        }
    }
}
