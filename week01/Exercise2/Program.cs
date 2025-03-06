using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();

        int grade;
        string letter = "O";

        Console.Write("What is your grade percentage? ");
        grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is {letter}");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congrats you passed the course! :D");
        }
        else
        {
            Console.WriteLine("Oh no! Keep trying :)");
        }

        Console.ReadLine();
    }
}