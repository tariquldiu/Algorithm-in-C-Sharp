using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinearyEquivalentFormInt
{
    class Program
    {

        public static void Main(string[] args)
        {
            int num, var, re, binary = 0, i = 1;

            Console.WriteLine("Enter a decimal number: ");
            num = int.Parse(Console.ReadLine());
            var = num;
            while (num != 0)
            {
                re = num % 2;
                num = num / 2;
                binary = binary + (re * i);
                i = i * 10;


            }

            Console.WriteLine("The binary equivalent of num is :" +binary);

            Console.ReadKey();
        }
    }
}