using System;

// Another reason people don't keep journals is that they get tired of being repetitive.
// Every day seems the same, and at a certain point, they get bored of writing the same thing over and over again.
// Daniel Malacara 03/12/2025 BYU
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");

        string fileName = "";
        int guiInput = 0;
        Journal myJournal = new Journal();


        while (guiInput != 5)
        {
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal");
            Console.WriteLine("4. Save journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            guiInput = int.Parse(Console.ReadLine());

            if (guiInput == 1)
            {
                NewEntry entry = new NewEntry();
                string _entry = entry.Display();

                myJournal._journal.Add(_entry);

            }
            if (guiInput == 2)
            {
                myJournal.DisplayAll();
            }
            if (guiInput == 3)
            {
                Console.WriteLine();
                Console.WriteLine("What is the name of the file?");
                fileName = Console.ReadLine();
                myJournal.LoadFile(fileName);
            }
            if (guiInput == 4)
            {
                Console.WriteLine();
                Console.WriteLine("What name do you want to give to the file?");
                fileName = Console.ReadLine();
                myJournal.SaveFile(fileName);
            }
            if (guiInput == 5)
            {
                continue;
            }

        }


    }
}