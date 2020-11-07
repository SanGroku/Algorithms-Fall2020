using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;
using System.Collections;

namespace Assignment_3___Data_Structures
{
    class ArrayvsMap
    {
        //Create a method that makes/explains what arrays are. 
        public void MakeArray()
        {
            //Explains what an array is
            Console.WriteLine("An array is a series of elements, or values stored and indexed from 0 to n-1.\n" +
                "Arrays are generally used to store multiple values in a single variable instead of using multiple.\n" +
                "An array can be single-simensional, multidimensional, or jagged.\n" +
                "Here's a pretty big example:\n");

            //Lets the user read the info
            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();

            //Turn a txt file into an array
            string[] textFile = File.ReadAllLines(@"C:\temp\LargeData.txt");

            //Print the txt file line by line
            foreach (var line in textFile)
            {
                Console.WriteLine(line + "\n");

            }
            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();
            Console.Clear();
        }

        //Creates a method that makes/explains what maps are
        public void MakeMap()
        {
            //Create an array for the txt file
            string[] textFile = File.ReadAllLines(@"C:\temp\LargeData.txt");

            //create a hashtable
            Hashtable hashtable = new Hashtable();

            //Add entries from the txt file to the hashtable
            foreach (string line in textFile)
            {
                if (!hashtable.ContainsKey(line))
                {
                    hashtable[line] = line;
                }
            }

            //Explain what a map is
            Console.WriteLine("Maps, or dictionaries, are abstract data types that contain a collection of keys and a collection of values.\n" +
                "Similar to elements in an array, each key of a map has a value associated to it. A hash table is a particular type of map.\n" +
                "It uses a hash function to generate a hash code, into an array of buckets or slots: the key is hashed and the resulting hash indicates where the value is stored.\n");
            
            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();

            //Print the entries in the hashtable
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value + "\n");
            }

            Console.WriteLine("The key difference between an array and a map is that an array has values.\n" +
                "Maps have keys and values. These keys cannot repeat. Therefor, the keys will always be unique.\n");

            Console.WriteLine("[Press any key to continue!]\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
