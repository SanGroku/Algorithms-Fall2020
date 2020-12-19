using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4___Sorting
{
    class HeapSort
    {
        public void heapDescription()
        {
            //Step 1: List the algorithm name
            Console.WriteLine("Algorithm #4: Heap Sort");

            //Step 2: Describe the algorithm
            Console.WriteLine("Heapsort is a comparison-based sort-in-place algorithm that takes" + "\n" +
                "no extra storage. It is often described as an improved selection sort." + "\n");

            //Step 3: Show asymptotic notation (best and worse case)
            Console.WriteLine("Asymptotic Notation:");
            Console.WriteLine("Best Case: O(n log n)");
            Console.WriteLine("Worst Case: O(n log n)" + "\n");

            //Step 4: Show the algorithm as pseudocode
            Console.WriteLine("Heapsort(Data: values)" + "\n" +
                " <Turn the array into a heap.>" + "\n" +
                "For i = <length of values> - 1 To 0 Step -1" + "\n" +
                " // Swap the root item and the last item." + "\n" +
                "Data: temp = values[0]" + "\n" +
                "values[0] = values[i]" + "\n" + 
                "values[i] = temp" + "\n\n"+
                "<Consider the item in position i to be removed from the heap," + "\n" +
                "so the heap now holds i - 1 items. Push the new root value" + "\n" +
                "down into the heap to restore the heap property.>" + "\n" +
                "Next i" + "\n" +
                "End Heapsort" + "\n");   
            
            //Move on
            Console.WriteLine("[Press Any Key to Continue]");
            Console.ReadKey();
            Console.Clear();
        }



    }
}
