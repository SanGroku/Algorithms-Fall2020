using System;
using System.IO;

namespace Assignment_4___Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert the txt file into an array
            string[] txtFile = File.ReadAllLines(@"C:\temp\scores.txt");    //Stores the txt file as an arrray
            int[] convertFile = new int[txtFile.Length];                    //an int to store the converted file

            for (int i = 0; i < txtFile.Length; i++)                        
            {
                convertFile[i] = Int32.Parse(txtFile[i]);                   //Converts the string array into an int array
            }

            //Call and run the various algorithms
            //Run the Bubble sort algorithm
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.bubbleDescription();
            bubbleSort.doBubbleSort(convertFile);

            //Run the Insertion sort algorithm            
            InsertionSort insertionSort = new InsertionSort();
            insertionSort.insertionDescription();
            insertionSort.doInsertionSort(convertFile);

            //Run the Selection sort algorithm
            SelectionSort selectionSort = new SelectionSort();


            //Run the Heap sort algorithm
            HeapSort heapSort = new HeapSort();


            //Run the Quick sort algorithm
            QuickSort quickSort = new QuickSort();


            //Run the Merge sort algorithm
            MergeSort mergeSort = new MergeSort();

        }
    }
}
