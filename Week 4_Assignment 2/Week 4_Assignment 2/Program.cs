using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExternalShuffler;

namespace Week_4_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new text entry that reads from a txt file
            string[] textEntry = File.ReadAllLines(@"C:\temp\ShuffleText.txt");
            
            //Shuffle the contents of the txt file
            textEntry.doShuffle();
           
            //Print the newly shuffled contents line by line
            foreach (var line in textEntry)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}
