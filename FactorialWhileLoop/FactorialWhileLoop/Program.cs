using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialWhileLoop
{
    class Program
    {
      
         static void Main(string[] args)
        {
            int num,fact;
            Console.WriteLine("Enter tha number : ");
           num= int.Parse(Console.ReadLine());


           fact = 1;
           while (num != 1)
           {
               fact = fact * num;
               num--;
           }

            Console.WriteLine("Factorial of tha number is : " + fact);
            Console.ReadKey();
        }
       
        
            
    }
}
