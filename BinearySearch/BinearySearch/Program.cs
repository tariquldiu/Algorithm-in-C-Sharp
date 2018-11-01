using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinearySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10] { 2, 5, 6, 8, 10, 15, 20, 22, 25, 26 };
            int start=0,end=9,mid,key=20;

           /* Console.WriteLine("Tha array is: ");
            for(start=0;start<=end;start++)
            {
            Console.WriteLine(n[start]);
            }*/

           // for (start = 0;start <= end; start++)
            do
            {
                mid = (start + end) / 2;
                if (n[mid] == key)
                {
                    Console.WriteLine("Number is "+n[mid]+" position is "+(mid + 1));
                    break;
                }
                else if (n[mid] > key)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
                
                Console.WriteLine("Every mid point is: "  +mid);
                
            }
            while (start <= end);
            
            
            Console.ReadKey();


           
        }
    }
}
