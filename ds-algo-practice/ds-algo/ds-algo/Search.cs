using System;
using System.Collections.Generic;
using System.Text;

namespace ds_algo
{
    public static class Search
    {
        public static void BinarySearch(int[] array, int length, int target)
        {
            int max = length - 1, min = 0;
            int guess, steps = 0;

            while (max >= min)
            {
                guess = (max + min) / 2;
                steps++;

                if (array[guess] == target)
                {
                    Console.WriteLine($"Input array: [{string.Join(", ", array)}]");
                    Console.WriteLine($"Binary search results: Item {target} with index: [{guess}] found in {steps} steps."); // target found
                    return;
                }
                else if (array[guess] > target)
                {
                    max = guess - 1; // target is in right-half
                }
                else
                {
                    min = guess + 1; // target is in right-half
                }
            }

            Console.WriteLine($"Not found!");
            return;
        }
    }
}
