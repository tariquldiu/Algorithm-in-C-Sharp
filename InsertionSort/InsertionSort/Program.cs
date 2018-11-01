using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int[] array =new int[5] { 4, 2, 6,1, 3 };
            int i, j, temp;

            Console.WriteLine("Tha array is: ");
            for(i=0;i<5;i++)
            {
                Console.WriteLine(array[i]);
            }

            for(i=1;i<5;i++)
            {
                j=i;
                while(j>0 && array[j]<array[j-1])
                {
                   temp=array[j];
                    array[j]=array[j-1];
                    array[j-1]=temp;
                    j--;
                }
            }
            Console.WriteLine("Tha Shorted array is: ");
            for (i = 0;i< 5; i++)
                Console.WriteLine(array[i] );
            Console.ReadKey();

        }
    }
}
        
    

