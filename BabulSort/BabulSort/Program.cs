using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabulSort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] n = new int[5] { 4, 2, 5, 7, 3};
            int i, j, temp;
            Console.WriteLine("Tha array is: ");
            for (i = 0; i<5;i++)
            {
                Console.WriteLine(n[i]);
            }

            for (i = 0; i < 4; i++)
            {
                j = i;
                for (j = i + 1; j < 5; j++)
                {

                    if (n[i] >n[j])
                    {
                        temp = n[i];
                        n[i] = n[j];
                        n[j] = temp;
                    }
                }
            }
                Console.WriteLine("Tha Shorted array is: ");
                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine(n[i]);
                }
                Console.ReadKey();
            

        }
    }

}

      /*static void Main(string[] args)
        {
            int[] a = { 30, 20, 50, 40, 10 };
            int t;
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int j = 1; j <= a.Length - 1; j++)
            {
                for (int i = 0; i <= a.Length - 2; i++)
                {
                    if (a[i] >a[j])
                    {
                        t = a[j];
                        a[j] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in a)
                Console.Write(aray + " ");
            Console.ReadLine();
        }
    }
}*/