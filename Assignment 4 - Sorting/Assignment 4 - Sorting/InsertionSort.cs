using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4___Sorting
{
    class InsertionSort
    {
        public void insertionDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("Algorithm #2: Insertion Sort" + "\n");

            //Step 2: Describe the algorithm
            Console.WriteLine("Insertion sort is a simple sorting algorithm that builds the final sorted array\n" +
                "(or list) one item at a time. It is much less efficient on large lists than more advanced algorithms\n" +
                "such as quicksort, heapsort, or merge sort.\n");

            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(n)");
            Console.WriteLine("Worst Case: O(n^2)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine("Pseudocode:\n" +
                "Insertionsort(Data: values[])\n" +
                "For i = 0 To <length of values> - 1\n" +
                "//Move item i into position\n" +
                "//in the sorted part of the array\n" +
                "< Find  the first index j where\n" +
                "j < i and values[j] > values[i].>\n" +
                "<Move the item into position j.>\n" +
                "Next i\n" +
                "End Insertionsort\n");

            //Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }

        public void doInsertionSort(int[] values)
        {
            //Display the values before being sorted
            Console.WriteLine("Here is the original set of values:\n");

            foreach (int a in values)
            {
                Console.Write(a + " ");
            }

            //Now sort
            Console.WriteLine("\n\nHere are the insertion sorted values:\n");

        }
    }
}
