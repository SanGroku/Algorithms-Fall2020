using System;
using System.IO;

namespace Assignment_6___Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert txt file into an array
            string[] txtFile = File.ReadAllLines(@"C:\temp\scores.txt");    
            int[] convertFile = new int[txtFile.Length];                    

            for (int i = 0; i < txtFile.Length; i++)
            {
                convertFile[i] = Int32.Parse(txtFile[i]);                   
            }

            //Create ints to search for in each method
            int firstSearch = 100;
            int secondSearch = 81;
            int thirdSearch = 66;

            //Call and run each algorithm
            //Run the Linear search 
            linearSearch linear = new linearSearch();
            linear.linearDescription();
            linear.doLinearSearch(convertFile, firstSearch);

            //Run the Binary search
            BinarySearch binary = new BinarySearch();
            binary.binaryDescription();

            //run the interpolation search
            InterpolationSearch interpolation = new InterpolationSearch();
            interpolation.interpolDescription();
        }
    }
}
