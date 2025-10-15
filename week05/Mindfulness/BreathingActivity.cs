class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            Console.Write($"Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write($"Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine("\n");
            
            if (DateTime.Now >= endTime) break;
        }

        DisplayEndingMessage();
    }
}