using System;

class Program
{
    static void Main(string[] args)
    {
        int menuChoice = 0;
        Console.Clear();

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                BreathingActivity breath = new BreathingActivity();
            }

            else if (menuChoice == 3)
            {
                ListingActivity listing = new ListingActivity();
            }

            else if (menuChoice == 2)
            {
                ReflectingActivity reflecting = new ReflectingActivity();
            }
        } while (menuChoice != 4);
    }
}