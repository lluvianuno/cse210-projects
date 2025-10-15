using System;
//made reflecting activity class and the Listing Activity class
//more clean by using a Random atribite to get prompts and questions.
//can also handle when user enters another thing that's not 1-4
class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            bool isNumber = int.TryParse(input, out choice);

            Console.Clear();

            if (!isNumber)
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
                continue;
            }
            if (choice == 1)
            {
                new BreathingActivity().Run();
            }
            else if (choice == 2)
            {
                new ReflectingActivity().Run();
            }
            else if (choice == 3)
            {
                new ListingActivity().Run();
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please choose a valid option.");
                Console.WriteLine("Press ENTER to continue...");
                Console.ReadLine();
            }
        }
    }
}
