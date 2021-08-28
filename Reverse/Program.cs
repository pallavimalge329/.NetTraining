using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {8, 15, 21, 25, 37 };

           int a = 0;
           int  b = arr.Length - 1;
            while (a < b)
            {
                // swap arr[start] and arr[end]

                int temp = arr[a];
                arr[a] = arr[b];
                arr[a] = temp;

              

                a = a + 1;
                b = b - 1;

                Console.WriteLine("Array: {0}, {1}", a , b);
                Console.ReadLine();
                // arr = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
