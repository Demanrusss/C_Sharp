using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProject
{
    internal class Program
    {
        unsafe static void Main(string[] args)
        {
            int[] managedarray = { 10, 20, 5, 2, 54, 9 };

            // Getting some memory in stack
            int* array = stackalloc int[managedarray.Length];

            Console.WriteLine("Copying values from managedarray to array");
            for (int i = 0; i < managedarray.Length; i++)
            {
                array[i] = managedarray[i];
                Console.WriteLine("The value: " + array[i]);
            }

            // Fixed array
            Console.WriteLine("\nUsing fixed array");

            fixed (int* arrayPtr = &managedarray[0])
            {
                for (int i = 0; i < managedarray.Length; i++)
                    Console.WriteLine("The value of fixed array: " + arrayPtr[i]);
            }

            // Understanding how much memory is used for variables
            int intSize = sizeof(int);
            Console.WriteLine($"\nThe memory used for int is - {intSize} bytes");
        }
    }
}
