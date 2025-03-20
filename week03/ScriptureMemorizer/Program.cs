using System;

class Program
{
    static void Main(string[] args)
    {
        int wordsToHide = 10;
        string input = "";

        Reference reference = new Reference("1 nefi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        while ((scripture.IsCompletelyHidden() == false) && (input != "quit"))
        {
            Console.Clear();
            Console.Write(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Clic ENTER to hide more words or type 'quit' to leave.");
            input = Console.ReadLine();

            scripture.HideRandomWords(wordsToHide);

        }

        if (input != "quit")
        {
        Console.Clear();
        Console.Write(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        }
        
        Console.WriteLine();
        Console.WriteLine("Well done, keep learning.");
        
    }
}