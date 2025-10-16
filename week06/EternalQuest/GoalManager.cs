using System;
using System.Collections.Generic;
using System.IO;
//can handle when file doesn't exts
//getters in goal class
class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;

        while (choice != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            int.TryParse(input, out choice);
            Console.WriteLine();

            if (choice == 1) CreateGoal();
            else if (choice == 2) ListGoalDetails();
            else if (choice == 3) SaveGoals();
            else if (choice == 4) LoadGoals();
            else if (choice == 5) RecordEvent();
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.WriteLine();
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];

            if (g is ChecklistGoal c)
            {
                // Mostrar [X] si está completa, sino [ ]
                string check = c.IsComplete() ? "X" : " ";
                Console.WriteLine($"{i + 1}. [{check}] {c.GetShortName()} ({c.GetDescription()}) -- Currently completed: {c._amountCompleted}/{c._target}");
            }
            else
            {
                string check = g.IsComplete() ? "X" : " ";
                Console.WriteLine($"{i + 1}. [{check}] {g.GetShortName()} ({g.GetDescription()})");
            }
        }
        Console.WriteLine();
    }


    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string goalPoints = Console.ReadLine();

        Goal newGoal;

        if (choice == "1")
        {
            newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
        }
        else if (choice == "2")
        {
            newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
        }
        else
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, target, bonus);
        }

        _goals.Add(newGoal);
        Console.WriteLine("\nGoal created!\n");
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].RecordEvent();
            _score += int.Parse(_goals[index]._points);
            Console.WriteLine($"You now have {_score} points.\n");
        }
        else
        {
            Console.WriteLine("Invalid goal number.\n");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("\nGoals saved!\n");
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!\n");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals = new List<Goal>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            if (parts.Length == 4) // SimpleGoal
            {
                SimpleGoal g = new SimpleGoal(parts[0], parts[1], parts[2]);
                if (bool.Parse(parts[3]))
                {
                    g.RecordEvent();
                }
                _goals.Add(g);
            }
            else if (parts.Length == 3) // EternalGoal
            {
                _goals.Add(new EternalGoal(parts[0], parts[1], parts[2]));
            }
            else if (parts.Length == 6) // ChecklistGoal
            {
                ChecklistGoal g = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[4]), int.Parse(parts[5]));
            
                for (int j = 0; j < int.Parse(parts[3]); j++)
                {
                    g.RecordEvent();
                }
                _goals.Add(g);
            }
        }

        Console.WriteLine();
    }

}

