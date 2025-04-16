using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Fitnes Center App");
        Console.WriteLine("");
        List<Activity> Fitness = new ();
        Fitness.Add(new Running(30, 5));
        Fitness.Add(new Running(45, 9));
        Fitness.Add(new Running(20, 3.2));
        Fitness.Add(new Cycling(60, 20));
        Fitness.Add(new Cycling(45, 25));
        Fitness.Add(new Cycling(30, 15));
        Fitness.Add(new Swimming(40, 40));
        Fitness.Add(new Swimming(30, 30));
        Fitness.Add(new Swimming(25, 20));

        foreach (Activity activity in Fitness)
        {
            activity.GetSummary();
            Console.WriteLine("");
        }
    }
}