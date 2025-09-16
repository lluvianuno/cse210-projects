using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whats your grade percentage? ");
        string gradeInText = Console.ReadLine();
        int gradeInPercentage = int.Parse(gradeInText);

        string letter = "";

        if (gradeInPercentage >= 90)
        {
            letter = "A";
        }
        else if (gradeInPercentage >= 80)
        {
            letter = "B";
        }
        else if (gradeInPercentage >= 70)
        {
            letter = "C";
        }
        else if (gradeInPercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradeInPercentage >= 70)
        {
            Console.WriteLine("Congratulations! You've passed the course!");
        }
        else if (gradeInPercentage < 70)
        {
            Console.WriteLine("You failed, we encourage you to try again!");
        }
    }
}