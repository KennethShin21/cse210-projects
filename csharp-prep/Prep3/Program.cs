using System;

namespace Prep3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Prep 3");

            Random randomGenerator = new Random();

            //Console.Write("What is the magic number? ");
            //string userInput = Console.ReadLine();
            //int magicNumber = int.Parse(userInput);
            int magicNumber = randomGenerator.Next(1,50);

            int guessNumber = -1;

            while (guessNumber != magicNumber)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());

                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else{
                Console.WriteLine("You guessed it!");
                }
            }
        }
    }
}
