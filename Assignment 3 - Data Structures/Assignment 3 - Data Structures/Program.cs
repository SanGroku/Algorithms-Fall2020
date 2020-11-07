using System;

namespace Assignment_3___Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the crested classes
            ArrayvsMap arrayvsMap = new ArrayvsMap();
            StackvsQueue stackvsQueue = new StackvsQueue();

            //Call the methods for ArrayvsMap
            arrayvsMap.MakeArray();
            arrayvsMap.MakeMap();

            //Call the methods for StackvsQueue
            stackvsQueue.MakeStack();
            stackvsQueue.MakeQueue();

            Console.ReadLine();
        }
    }
}
