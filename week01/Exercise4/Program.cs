using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int userNumber = 1;
        int sumTotal = 0;
        float avgTotal = 0;
        int largestNum = 0;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        Console.WriteLine();
        foreach (int number in numbers)
        {
            sumTotal += number;
            if (number > largestNum)
            {
                largestNum = number;
            }
        }
        Console.WriteLine($"The sum is: {sumTotal}");
        avgTotal = ((float)sumTotal) / numbers.Count;
        Console.WriteLine($"The average is: {avgTotal}");
        Console.WriteLine($"The largest number is: {largestNum}");
    }
}