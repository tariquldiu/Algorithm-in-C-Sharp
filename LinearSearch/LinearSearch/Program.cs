using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[5] { 50, 20, 40, 60, 10 };
            int i,key;
            Console.WriteLine("Tha array is: ");
            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine(n[i]);
            }
            key = 40;
           int  Chack = 0;
            for (i = 0; i <5; i++)
            {
                if (n[i] == key)
                {
                    Chack = 1;
                    
                     break;
                }
               
            }

            if (Chack == 1)
            {
                Console.WriteLine("Number is " + key + " found," + " Position is " + (i+1));
            }

            else
                Console.WriteLine("Tha number is not in tha array");
            
            Console.ReadKey();

        }
    }
}
