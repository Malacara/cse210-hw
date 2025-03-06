using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();

        Random magicNumber = new Random();
        int number = magicNumber.Next(1, 100);
        Console.WriteLine($"The magic number is {number}");

        int pick = 0;
        while (pick != number)
        {
            Console.Write("What is your guess? ");
            pick = int.Parse(Console.ReadLine());

            if (pick > number)
            {
                Console.WriteLine("Lower");
            }
            else if (pick < number)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guessed it!");

    }
}