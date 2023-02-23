using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace MethodsExercise3
{
    class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through -1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                if (i == 0) //console only showing 39 to -1000 - recommendation by Daniel Aguirre
                {
                    Console.ReadKey();
                }

                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int i = 3; i <= 999; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualCheck()
        {
            Console.WriteLine("Enter a number...");
            var firstEntry = Console.ReadLine();

            Console.WriteLine("Enter a second number...");
            var secondEntry = Console.ReadLine();

            if (firstEntry == secondEntry)
            {
                Console.WriteLine($"The numbers are equal!");
            }
            else
            {
                Console.WriteLine($"Those numbers are not equal!");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void EvenOdd()
        {
            Console.WriteLine("Enter a number to check if it's even or odd...");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative
        public static void PositiveNegativeCheck()
        {
            Console.WriteLine("Enter a number to check if it's postivie or negative...");
            var positiveNegative = int.Parse(Console.ReadLine());

            if (positiveNegative > 0)
            {
                Console.WriteLine($"{positiveNegative} is a positive number!");
            }
            else if (positiveNegative < 0)
            {
                Console.WriteLine($"{positiveNegative} is a negative number!");
            }
            else
            {
                Console.WriteLine($"{positiveNegative} is neither a positive or negative number");
            }
        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge()
        {
            Console.WriteLine("Please enter your age to verify your voting eligibility...");
            var votingCheck = int.Parse(Console.ReadLine());
            var ageMinimum = 18;

            if (votingCheck <= ageMinimum)
            {
                Console.WriteLine("You are not eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are old enough to vote!");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void RangeCheck()
        {
            Console.WriteLine("Enter a number to check if it's within range...");
            int response = int.Parse(Console.ReadLine());


            if (response >= -10 && response <= 10)
            {
                Console.WriteLine($"The number {response} is within the range of -10 to 10.");
            }
            else
            {
                Console.WriteLine($"The number {response} is not within the range of -10 to 10.");
            }
        }


        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number to multiply by 12...");
            var numberInput = int.Parse(Console.ReadLine());

            var numbersList = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};

            foreach (int num in numbersList)
            {
                Console.WriteLine($"{numberInput} * {num} = {numberInput * num}");
            }
        }
        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintThousand();
            Console.WriteLine();

            ByThree();
            Console.WriteLine();

            EqualCheck();
            Console.WriteLine();

            EvenOdd();
            Console.WriteLine();

            PositiveNegativeCheck();
            Console.WriteLine();

            VotingAge();
            Console.WriteLine();

            RangeCheck();
            Console.WriteLine();

            MultiplicationTable();
            Console.WriteLine();
        }
    }
}