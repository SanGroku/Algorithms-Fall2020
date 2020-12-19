using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6___Searching
{
    class InterpolationSearch
    {
        public void interpolDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("Algorithm #3: Interpolation Search");
            //Step 2: Describe the algorithm
            Console.WriteLine("Requires a sorted data set. Binary search always chooses the middle" + "\n" +
                " of the data set before discarding one half or the other. Interpolation search uses" + "\n" +
                " keys. For interpolation search to work efficiently data must be uniformly distributed " + "\n" +
                "(in addition to being sorted)." + "\n");
            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(log n)");
            Console.WriteLine("Worst Case: O(n)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine();

            //Step 5: Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }

        public int doInterpolSearch(int[] list, int data)
        {
            int low = 0;
            int mid = -1;
            int high = list.Length - 1;
            int index = -1;

            while (low <= high)
            {
                mid = (int)(low + (((double)(high - low) / (list[high] - list[low])) * (data - list[low])));

                if (list[mid] == data)
                {
                    index = mid;
                    break;
                }
                else
                {
                    if (list[mid] < data)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            return index;
        }
    }
}
