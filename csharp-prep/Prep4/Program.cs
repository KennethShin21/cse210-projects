using System;
using System.Collections.Generic;

namespace Prep4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 4");

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            List<int> numbers = new List<int>();

            int userInput = -1;
            while (userInput != 0)
            {
                Console.Write("Enter number: ");
                userInput = int.Parse(Console.ReadLine());
                numbers.Add(userInput);
            }
            // for getting the sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is {sum}.");

            // for getting the average
            float average = sum / numbers.Count;
            Console.WriteLine($"The average is: {average}.");

            // for getting the largest number
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The largest number is {max}.");
        }
    }
}
