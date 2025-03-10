using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine();

        // Job.cs
        Job job1 = new Job();

        job1._company = "BYU";
        job1._jobTitle = "Student";
        job1._startYear = 2024;
        job1._endYear = 2027;

        Job job2 = new Job();

        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Job job3 = new Job();

        job3._company = "Microsoft";
        job3._jobTitle = "Software Engineer";
        job3._startYear = 2019;
        job3._endYear = 2022;

        // Resume.cs

        Resume myResume = new Resume();
        myResume._name = "Daniel Malacara";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        // Display
        myResume.Display();
        
    }
}