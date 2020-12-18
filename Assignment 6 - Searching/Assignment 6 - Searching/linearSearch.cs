using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6___Searching
{
    class linearSearch
    {
        public void linearDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("algorithm #1: Linear Sort" + "\n");

            //Step 2: Describe the algorithm
            Console.WriteLine("The Linear search algorithm sequentially searches each element in a data set." + "\n" +
                "This method of searching is not really effective unless the data set is small." + "\n");

            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(1)");
            Console.WriteLine("Worst Case: O(n)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine("Begin" + "\n"+
                "Set i = 0" + "\n" +
                "If Li = T, go to line 4" + "\n" +
                "Increase i by 1 and go to line 2" + "\n" +
                "If i < n then return i" + "\n" +
                "End" + "\n");

            //Step 5: Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }

        public int doLinearSearch(int[] data, int item)
        {
            int N = data.Length;

            for (int i = 0; i < N; i++)
            {
                if (data[i] == item)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
