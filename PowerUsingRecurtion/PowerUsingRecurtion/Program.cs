using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUsingRecurtion
{
    class Program
    {
        static void Main(string[] args)
        {
            int  num = Power(10, 3);
            Console.WriteLine(num);
            Console.ReadKey();
            
        }
         static int  Power(int   @base, int exponent)
        {
            if(exponent<0)
               {
                 Console.Error.WriteLine("Usage of this function is limited to positive exponents only");
                throw new Exception();
               }
            else if (exponent == 0)
            {
                return 1;
            }
            else if (exponent == 1)
            {
                return @base;
            }
            else
            {
                return @base * Power(@base, exponent - 1);
            }

          }
              
    }  
}
    
