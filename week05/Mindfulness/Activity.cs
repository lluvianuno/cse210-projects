using System.Runtime.InteropServices;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n");
        Console.WriteLine(_description + "\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("\nGet Ready...");
        ShowSpinner(800);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(800);
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(800);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("/"); Thread.Sleep(seconds); Console.Write("\b \b");
        Console.Write("—"); Thread.Sleep(seconds); Console.Write("\b \b");
        Console.Write("\\"); Thread.Sleep(seconds); Console.Write("\b \b");
        Console.Write("|"); Thread.Sleep(seconds); Console.Write("\b \b");
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}