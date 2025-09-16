using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        Console.Write("What is your guess? ");
        string guessNumber = Console.ReadLine();
        int guess = int.Parse(guessNumber);

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            guessNumber = Console.ReadLine();
            guess = int.Parse(guessNumber);

        }

        Console.WriteLine("You guessed it!");
    }
}