using System;
using System.Collections.Generic;
using System.Text;

namespace ExternalShuffler
{
    public static class FisherYatesShuffler
    {
        //Make a new random number
        private static Random randomnNum = new Random();

        //Where the shuffling will take place
        public static void doShuffle(this object[] objects)
        {
            for (int i = objects.Length - 1; i > 0; i--)
            {
                //Get some random number between 0 and i
                swapObjects(objects, i, getRandomNum(i));
            }
        }

        private static void swapObjects(object[] objects, int i, int j)
        {
            //Add a temporary variable
            object temp = objects[i]; //Temporarily store i
            objects[i] = objects[j];  //Swap j and i
            objects[j] = temp;
        }

        private static int getRandomNum(int i)
        {
            return randomnNum.Next(i + 1);
        }
    }
}
