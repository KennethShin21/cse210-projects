using System;

namespace Prep2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 2");
            Console.Write("What is your grade percentage? ");
            string gradePercentage = Console.ReadLine();
            int number = int.Parse(gradePercentage);
            Console.WriteLine("");
            string letter = "";
            
            if (number >= 90)
            {
                letter = "A";
            }
            else if (number >= 80)
            {
                letter = "B";
            }
            else if (number >= 70)
            {
                letter = "C";
            }
            else if (number >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your grade is: {letter}.");

            if (number >=70)
            {
                Console.WriteLine("Congratulations for getting a passing grade!");
            }
            else
            {
                Console.WriteLine("Sorry but you didn't passed! Try again next time.");
            }


        }
    }
}
