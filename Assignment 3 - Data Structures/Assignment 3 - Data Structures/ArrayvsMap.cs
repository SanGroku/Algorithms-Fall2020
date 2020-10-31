using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;

namespace Assignment_3___Data_Structures
{
    class ArrayvsMap
    {
        //Create a method that makes/explains what arrays are. 
        public void MakeArray()
        {
            var list = new List<string>(); 

            //Explains what an array is
            Console.WriteLine("An array is a series of elements, or values stored and indexed from 0 to n-1.\n" +
                "Arrays are generally used to store multiple values in a single variable instead of using multiple.\n" +
                "An array can be single-simensional, multidimensional, or jagged.\n" +
                "Here's a pretty big example:\n");

            using (StreamReader sr = new StreamReader(@"C:\temp\LargeData.txt"))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    list.Add(line);
                }

                string[] example = list.ToArray();
                Console.WriteLine(example);
            }
        }

        //Creates a method that makes/explains what maps are
        public void MakeMap()
        { }
    }
}
