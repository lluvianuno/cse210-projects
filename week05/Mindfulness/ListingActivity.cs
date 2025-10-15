using System;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain idea.";

        _prompts = new List<string>
        {
            "When have you felt Heavenly Father's love for you this month?",
            "Who are some of your personal heroes?",
            "Who are the people you feel grateful for?",
            "What was your favorite moment this week?",
            "What is something you want to improve about yourself?"
        };

        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        List<string> responses = GetListFromUser();

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        Console.WriteLine($"--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> responses = new List<string>();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

         _count = responses.Count;

        Console.WriteLine($"You listed {_count} items.");
        return responses;
    }

}