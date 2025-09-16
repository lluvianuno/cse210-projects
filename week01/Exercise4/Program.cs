using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int number;

        do
        {
            Console.Write("Enter number (0 to quit): ");
            string numberToAdd = Console.ReadLine();
            number = int.Parse(numberToAdd);

            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        int sum = 0;
        int count = 0;
        int largest = numbers[0];

        foreach (int n in numbers)
        {
            sum += n;
            count++;

            if (n > largest)
            {
                largest = n;
            }
        }
        double average = (double)sum / count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}