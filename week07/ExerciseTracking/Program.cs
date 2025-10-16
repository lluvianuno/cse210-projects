using System;

class Program
{
    static void Main(string[] args)
    
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running(new DateTime(2022, 11, 3), 30, 4.8);
        Cycling cycle1 = new Cycling(new DateTime(2022, 11, 3), 31, 3);
        Swimming swim1 = new Swimming(new DateTime(2022, 11, 3), 45, 30);

        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swim1);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}