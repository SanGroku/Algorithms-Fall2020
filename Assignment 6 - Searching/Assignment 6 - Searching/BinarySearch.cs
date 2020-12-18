using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6___Searching
{
    class BinarySearch
    {
        public void binaryDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("Algorithm #2: Binary Search" + "\n");

            //Step 2: Describe the algorithm
            Console.WriteLine("The binary search algorithm requires a sorted data set. It compares" + "\n" + 
                "valeus in the middle of the data set to the desired value. if the values are equal," + "\n" +
                "the target has been found. If the values are not equal, the algorithm determines which" + "\n" +
                "half of the data set will contain the target. this is repeated recursively with the remaining" + "\n" +
                "half of the data set." + "\n");

            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(log n)");
            Console.WriteLine("Worst Case: O(n)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine("binary_search(A, n, T) is" +
                "L = 0" + "\n" +
                "R = n - 1" + "\n" +
                "while L <= R do" + "\n" +
                "m = floor((L + R) / 2)" + "\n" +
                "if A[m] < T then" + "\n" +
                "L = m + 1" + "\n" +
                "else if A[M] > T then" + "\n" +
                "R = m - 1" + "\n" +
                "else:" + "\n" +
                "return m" + "\n" +
                "return unsuccessful" + "\n");

            //Step 5: Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
