using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] myNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

          
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();
            

            foreach (int num in myNumbers)
            {
               var sum = num % 2;

                if (sum == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }

            }


            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            Console.WriteLine("Even's List:");
            foreach (int num in evens)
            {
                Console.WriteLine($"{num}");

            }

            Console.WriteLine("Odd's List:");
            foreach (int num in odds)
            {
                Console.WriteLine($"{num}");

            }
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
