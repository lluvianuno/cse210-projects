//when the program finishes running, it prints a nice message to the user, showing which scripture has been memorized
//it doesn't matter if the user types "QUIT" or "Quit" instead of "quit" etc., it will still finish the program without trouble

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Proverbs", 3, 5);
        Scripture scripture1 = new Scripture(reference1, "Trust in the Lord with all thine heart; and lean not unto thine own understanding.");

        Console.Clear();
        Console.WriteLine(scripture1.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");


        while (!scripture1.IsCompletelyHidden())   //if function returns false my loop will continue because that means that theres still words to hide
        {
            string input = Console.ReadLine();
            input = input.ToLower();  //this means it will work even if you type "QUIT" or "Quit"
            if (input == "quit")
                break;

            scripture1.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine(scripture1.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        }
        Console.WriteLine($"Good job! You've memorized {reference1.GetDisplayText()}");

    }
}