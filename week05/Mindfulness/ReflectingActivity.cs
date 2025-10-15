class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts = new List<string>
        {
            "Think of a time when you accomplished one of your biggest goals.",
            "Think of a time when you stood firm in adversity.",
            "Think of a moment of support with a loved one.",
            "Think of a moment you would like to relive."
        };

        _questions = new List<string>
        {
            "What was the most difficult part about it?",
            "Why was this experience meaningful to you?",
            "How did it make you feel?",
            "If you could go back and change something, what would it be?",
            "What did you learn about yourself through this experience?",
            "What did you learn about this experience?",
            "If you could say something to yourself at that moment, what would it be?",
            "Do you think it made you a different person?",
            "How did it affect you?"
        };

        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            DisplayQuestions();
            ShowSpinner(3000);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);

        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
    }
    
    public void DisplayQuestions()
    {
        Console.Write($"{GetRandomQuestion()} ");
    }
}