using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4___Sorting
{
    class SelectionSort
    {
        public void selectionDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("Algorithm #3: Selection Sort");

            //Step 2: Describe the algorithm
            Console.WriteLine("Selection sort is an in-place comparison sorting algorithm. It is " + "\n" +
                "inefficient on large lists, and generally performs worse than insertion sort." + "\n");

            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(n^2)");
            Console.WriteLine("Worst Case: O(n^2)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine("Selectionsort(Data: values[])" + "\n" +
                "For i = 0 To <length of values> - 1" + "\n" +
                "// Find the item that belongs in position i." + "\n" +
                "<Find the smallest item with index j >= i.>" + "\n" +
                "<Swap values[i] and values[j].>" + "\n" +
                "Next i" + "\n" +
                "End SelectionSort" + "\n");

            //Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }

        public void doSelectSort(int[] values)
        {
            //Display the values before 
            Console.WriteLine("Here is the original set of values:\n");
            
            foreach (int a in values)
            {
                Console.Write(a + " ");
            }

            //Now sort
            Console.WriteLine("\n\nHere are the selection sorted values:\n");

            int small;

            for (int i = 0; i < values.Length - 1; i++)
            {
                small = 1;

                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j] < values[small])
                    {
                        small = j;
                    }
                }

                int temp = values[small];
                values[small] = values[i];
                values[i] = temp;
            }

                //Display the values after sorting
                foreach (int b in values)
                {
                    Console.Write(b + " ");
                }
            

            //Move on to the next algorithm
            Console.WriteLine("\n\n[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
