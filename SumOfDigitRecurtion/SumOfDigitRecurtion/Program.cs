using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitRecurtion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            pro pr = new pro();
            Console.WriteLine("Enter tha number: ");
            num =int.Parse(Console.ReadLine());
            result = pr.sum(num);
            Console.WriteLine("Tha sum of digit is : "+result);
            Console.ReadKey();
        }
        
    }
    class pro
    {
        public int sum(int num)
        {
           
           if(num!=0)        
            {
              return (num%10+sum(num/10));
            }
            else
           {
             return 0;
           }
         }
    }
}
