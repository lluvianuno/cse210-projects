using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");
        Console.WriteLine($"{assignment1.GetSummary()}");
        Console.WriteLine($"{assignment1.GetHomeworkList()}");

        WritingAssignment assignment2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"{assignment2.GetWritingInformation()}");
    }
}