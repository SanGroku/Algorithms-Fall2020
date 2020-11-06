# Week 4
## Assignment 2: Fisher-Yates Shuffle
To put it simply this is the equivalent of putting names in a hat, and randomly drawing an element from said hat until no element remains. 

**Originally**

The method created in 1938 by Ronald Fisher and Frank Yates stated that:
1. Write down the numbers from 1 through, say *N*.
2. Pick a random number *k* between one and the number unstruck numbers remaining (inclusive).
3. Counting from the low end, strike out the *k*th number not yet struck out, and write it down at the end of a separate list. 
4. Repeat from step 2 until all the numbers have been struck out. 
5. The sequence of numbers written down in step 3 is now a random permutation of the original numbers.

From [Source](https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle)

**The new version**

Cuts down on some of the extra steps found in the older version. 

**What does my program do?**

The program I made takes a txt file, turns it into an array, and then shuffles that data. 
