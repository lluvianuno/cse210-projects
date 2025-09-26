using System;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

//The program also displays (and prompts), the user for it's name.

class Program
{
    static void Main(string[] args)
    {

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();
        int response = 0;

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hi! {name}.");

        while (response != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            Console.WriteLine();

            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                Entry entry = new Entry();
                entry._name = name;
                string promptText = prompt.GetRandomPrompt();
                Console.WriteLine(promptText);
                string answer = Console.ReadLine();

                entry._promptText = promptText;
                entry._entryText = answer;
                entry._date = DateTime.Now.ToShortDateString();

                journal.AddEntry(entry);
            }

            if (response == 2)
            {
                journal.DisplayAll();
            }

            if (response == 3)
            {
                journal.LoadFromFile();
            }

            if (response == 4)
            {
                journal.SaveToFile();
            }

        }
    }
}