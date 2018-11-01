using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[6] { 3, 6, 4, 1, 8, 2 };

            int i,j,temp,min;
            Console.WriteLine("Tha array is: ");
            for (i = 0; i< 6; i++)
            {
                Console.WriteLine( n[i]);
            }

            for (i = 0; i < 5; i++)
            {
                min = i;
                for (j = i+1; j < 6; j++)
                {
                    if (n[j] <n[ min])
                    {
                        min = j;
                    }
                }
                temp = n[i];
                n[i ] = n[min];
                n[min] = temp;
               

            }
            Console.WriteLine("Tha shorted array is: ");
            for (i = 0; i < 6; i++)
           {
                Console.WriteLine(n[i]);
            }
            Console.ReadKey();

        }
    }
}
