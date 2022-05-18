using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[10][];

            // Memory allocation for each row of the array
            for (int i = 0; i < jaggedArray.Length; i++)
                jaggedArray[i] = new int[i];

            // Using the array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = j;
                    Console.Write(jaggedArray[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
