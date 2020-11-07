using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assignment_3___Data_Structures
{
    class StackvsQueue
    {
        public void MakeStack()
        {
            //Create an array for the txt file
            string[] textFile = File.ReadAllLines(@"C:\temp\LargeData.txt");

            //create an example of a stack
            Stack<string> wordStack = new Stack<string>();

            //explain what the stack is
            Console.WriteLine("The stack is a collection that stores elements in a LIFO style.\n" +
                "This means that the last element in is the first element out.\n" +
                "Thhe stack is useful when it comes to storing temporary data.\n" +
                "Generally, you may want to delete an element after retrieving its value.\n");

            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();


            //Add txt file entries to the stack
            foreach (string line in textFile)
            {
                wordStack.Push(line);
                Console.WriteLine(line);
            }

            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();
            Console.Clear();
        }

        public void MakeQueue()
        {
            string[] textFile = File.ReadAllLines(@"C:\temp\LargeData.txt");

            //Create a queue example
            Queue<string> storeData = new Queue<string>();

            //Explain what the queue is
            Console.WriteLine("Unlike the stack, the queue is a collection that stores elements in a FIFO style.\n" +
                "What this means is that the queue sorts by first in, first out. It contains the elements in the\n" +
                "order they were added.\n");
            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();

            foreach (string line in textFile)
            {
                storeData.Enqueue(line);
                Console.WriteLine(line);
            }

            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
