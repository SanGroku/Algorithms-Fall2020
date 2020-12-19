using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4___Sorting
{
    class MergeSort
    {
        public void mergeDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("Algorithm #6: Merge Sort");

            //Step 2: Describe the algorithm
            Console.WriteLine("Like Merge Sort, QuickSort is a Divide and Conquer algorithm. It picks " + "\n" +
                "an element as pivot and partitions the given array around the picked pivot." + "\n");

            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(n log n)");
            Console.WriteLine("Worst Case: O(n log n)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine();

            //Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
