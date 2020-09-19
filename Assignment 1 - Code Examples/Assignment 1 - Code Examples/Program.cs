using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_1___Code_Examples
{
    /*Objecttive: Create methods that show...
     * Constamt O(1)
     * Linear O(n)
     * Quadratic O(n^2)
     */

    class Program
    {
        static void Main(string[] args)
        {
            //Tests the 0(1) method
            Console.WriteLine(IsEven(204)); 

            //Tests the 0(n) method
            String[] animalList = {"dog", "cat", "fish", "rabbit", "ferret", "snail", "lizard"}; //Creates a list of words 
            String valueFind = "pizza"; //A single value or word to find
            Console.WriteLine(FindValue(animalList, valueFind)); //Tries to find that word in the list

            //Tests the O(n^2) method
            string[] birds = {"Hawk", "Falcon", "Raven", "Swallow", "Sparrow", "Falcon", "Chicken"}; //Creates an array of words. Note: Birds are rad :)
            List<string> BirdList = new List<string>(); //Makes a list
            BirdList.AddRange(birds); //Adds woords to the lists
            Console.WriteLine(ContainsMultiple(BirdList)); //Checks for duplicates

            Console.ReadLine();
        }

        //Constant O(1) -> Will always remain the same
        public static bool IsEven(int number) //The user gives a number..
        {
            return number % 2 == 0; //Is it divisible by 2?? Then it's even!
        }

        //Linear O(n) -> Will grow linearly based on input data size
        public static bool FindValue(String[] strings, String value)
        {
            //Loops through the string of words
            for (int i = 0; i < strings.Length; i++)
            {
                //if a value in the string is equal to the value the user inputs
                if (strings[i] == value)
                {
                    return true; //The method is true!
                }
            }
            return false;
        }

        //Quadratic O(n^2) -> Proportional to the square of the size of the input
        public static bool ContainsMultiple(List<string> elements)
        {
            for (int count = 0; count < elements.Count; count++) //So this is O(n^1)
            {
                for (int innerCount = 0; innerCount < elements.Count; innerCount++) //And this is O(n^2) ???
                {
                    if (count == innerCount)
                    {
                        continue;
                    }
                    if (elements[count].Equals(elements[innerCount]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
