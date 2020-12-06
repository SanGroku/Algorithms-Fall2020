using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4___Sorting
{
    class BubbleSort
    {
        //Describes the algorithm and shows the pseudocode. 
        public void bubbleDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("Algorithm #1: Bubble Sort" + "\n");

            //Step 2: Describe the algorithm
            Console.WriteLine("The bubble sort algorithm starts at the beginning of an array and swaps the first\n" +
                "two elements if the first is greater than the second. The algorithm then moves on to the next\n" +
                "pair and so on.\n");

            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(n)");
            Console.WriteLine("Worst Case: O(n^2)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine("Pseudocode:\n" +
                "Bubblesort(Data: values[])\n" +
                "//Repeat until the array is sorted.\n" +
                "Boolean: not_sorted = True\n" +
                "While (not_sorted)\n" +
                "//Assume we won't find a pair to swap.\n" +
                "not_sorted = False\n" +
                "//Search the array for adjacent items that are out of order.\n" +
                "for i = 0 To <length of values> - 1\n");

            Console.WriteLine("//See if items i and i - 1 are out of order.\n" +
                "If (values[i] < values[i - 1]) Then\n" +
                "//Swap them.\n" +
                "Data: temp = values[i]\n" +
                "values[i] = values[i - 1]\n" +
                "values[i - 1] = temp\n");

            Console.WriteLine("//The array isn't sorted after all\n" +
                "not_sorted = True\n" +
                "End if\n" +
                "Next i\n" +
                "End while\n" +
                "End Bubblesort\n");

            //Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }

        public void doBubbleSort(int[] values)
        {
            //Display the values before being sorted
            Console.WriteLine("Here is the original set of values:\n");
            
            foreach (int a in values)
            {
                Console.Write(a + " ");
            }

            //Now sort
            Console.WriteLine("\n\nHere are the bubble sorted values:\n");

            bool done = false;      //Starts the while loop

            while (! done)
            {
                done = true;      //Assume pair to swap is not found

                for (int i = 0; i < values.Length - 1; i++)
                {
                    if (values[i] > values[i + 1])
                    {
                        //Swap
                        int temp = values[i];
                        values[i] = values[i + 1];
                        values[i + 1] = temp;

                        done = true;
                    }
                }

                //Display the values
                foreach (int j in values)
                {
                    Console.Write(j + " ");
                }
            }

            //Move on to the next algorithm
            Console.WriteLine("\n\n[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
