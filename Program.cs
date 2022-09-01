﻿namespace Clase07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input the numbers
            Console.WriteLine("Hello, enter 10 numbers and you will get some information about them");
            int[] numbersEntered = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Input your number {i+1}");
                numbersEntered[i] = int.Parse(Console.ReadLine());
            }

            //Show all the numbers
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Your number {i+1} is: {numbersEntered[i]}");
            }

            //Sum all numbers
            int sum = 0;
            for (int i = 0; i < numbersEntered.Length; i++)
            {
                sum += numbersEntered[i];
            }
            Console.WriteLine($"The sum of all your numbers is {sum}");

            //Max number
            int maxNumber = numbersEntered[0];
            for (int i = 1; i < numbersEntered.Length; i++)
            {
                if (numbersEntered[i] > maxNumber)
                {
                    maxNumber = numbersEntered[i];
                }
            }
            Console.WriteLine($"The higher number in your list is {maxNumber}");

            //Min number
            int minNumber = numbersEntered[0];
            for (int i = 1; i < numbersEntered.Length; i++)
            {
                if (numbersEntered[i] < minNumber)
                {
                    minNumber = numbersEntered[i];
                }
            }
            Console.WriteLine($"The lower number in your list is {minNumber}");

            //average number
            double averageNumber = sum / 10d;
            Console.WriteLine($"The average of your numbers is {averageNumber}");
        }
    }
}