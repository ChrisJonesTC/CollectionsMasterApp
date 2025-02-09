﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            //Done:// Create an integer Array of size 50
            var numbers = new int[50];

            //Done:// Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbers);



            //Done:// Print the first number of the array
            Console.WriteLine($"{numbers[0]}");

            //Done:// Print the last number of the array            
            Console.WriteLine($"{numbers[numbers.Length - 1]}");
            
                        Console.WriteLine("All Numbers Original");
            
            NumberPrinter(numbers);//UNCOMMENT this method to print out your numbers from arrays or lists
            
                        Console.WriteLine("-------------------");

            //Done:// Reverse the contents of the array and then print the array out to the console.

                        Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(numbers);
            

                        Console.WriteLine("-------------------");

            //Done:// Create a method that will set numbers that are a
            //multiple of 3 to zero then print to the console all numbers
                        Console.WriteLine("Multiple of three = 0: ");
            
            ThreeKiller(numbers);

                        Console.WriteLine("-------------------");

            //Done:// Sort the array in order now
            /*      Hint: Array.____()      */
                        Console.WriteLine("Sorted numbers:");

            Array.Sort(numbers);
            NumberPrinter(numbers);

            //Linq method//
            //var sorted = numbers.OrderBy(x => x);
            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Done: Create an integer List
            var numbList = new List<int>();

            //Done: Print the capacity of the list to the console
            
            Console.WriteLine($"{numbList.Capacity}");
            
            //Done: Populate the List with 50 random numbers between 0 and 50
            //you will need a method for this

            Populater(numbList);

            //Done: Print the new capacity

            Console.WriteLine($"{numbList.Capacity}");

            
                        Console.WriteLine("---------------------");

            //Done: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            //Console.WriteLine("What number will you search for in the number list?");

            int userNumb;
            bool isNumber;
            
            do
            {

                Console.WriteLine("What number will you search for in the number list?");
                isNumber = int.TryParse(Console.ReadLine(), out userNumb);

            } while (isNumber == false);

            NumberChecker(numbList, userNumb);

                        Console.WriteLine("-------------------");

                        Console.WriteLine("All Numbers:");
            
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbList);
            
                        Console.WriteLine("-------------------");


            //Done: Create a method that will remove all odd numbers from the list then print results
                        Console.WriteLine("Evens Only!!");
            
            OddKiller(numbList);
            
                        Console.WriteLine("------------------");

            //Done: Sort the list then print results
                        Console.WriteLine("Sorted Evens!!");
            numbList.Sort();
            NumberPrinter(numbList);
            
                        Console.WriteLine("------------------");

            //Done: Convert the list to an array and store that into a variable
            
            var myArray = numbList.ToArray();   

            //Done: Clear the list
            numbList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {//Create a method that will set numbers that are a multiple of 3 to zero
         //then print to the console all numbers
            for (int i = 0; i < numbers.Length; i++)
            {
               if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }

            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {//Done: Create a method that will remove all odd numbers from the list then print results
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)
                {
                    numberList.Remove(numberList[i]);
                }
            }

            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {//Done: Create a method that prints if a user number is present in the list
         //Remember: What if the user types "abc" accident your app should handle that!
            { 
                if(numberList.Contains(searchNumber))         //(searchNumber == numberList[i])
                {
                    Console.WriteLine($"Your number is in the list!");
                }
                else 
                {
                    Console.WriteLine($"This is an invalid response!");                
                }
              
            }
        }

        private static void Populater(List<int> numberList)
        {//Done: Populate the List with 50 random numbers between 0 and 50
         //you will need a method for this
            for (int i = 0; i < 50; i++)
            {
                Random randNum = new Random();
                var number = randNum.Next(0, 50);
                numberList.Add(number);
            }
        }

        private static void Populater(int[] numbers)
        {//Done: Create a method to populate the number array with
         //50 random numbers that are between 0 and 50
            for (int i = 0; i < numbers.Length; i++)
            {
                Random randNum = new Random();
                numbers[i] = randNum.Next(0, 50);   
            }
        }        

        private static void ReverseArray(int[] array)
        {//Done: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(array);
            NumberPrinter(array);
            
            
            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //   int rev = array[i];
            //   array[i] = array[array.Length - i - 1];
            //   array[array.Length - i - 1] = rev;
            //}
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
