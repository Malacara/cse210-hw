using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("My first video", "Jacob2000", 600);
        Video video2 = new Video("how to use a blender", "Ninja", 240);
        Video video3 = new Video("How to be Happy", "Awesome World", 1800);

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        video1.AddComment("Nice video", "Jackie");
        video1.AddComment("Your experience was awesome", "Daniel");
        video1.AddComment("I hope you continue sharing more videos", "Kevs");

        video2.AddComment("How do I turn off the blender???", "SonicBoy");
        video2.AddComment("Thank You for this tutorial", "Grandma117");
        video2.AddComment("I dont have a blender but I want to buy one, any recommendation?", "TigerRoar");

        video3.AddComment("You Understand Me Perfectly.", "SadPepe");
        video3.AddComment("Thank you, I needed to hear this.", "MyNameIsJeff");
        video3.AddComment("Who wants some tacos while is reading the comments?", "TacoLoveer");

        Console.WriteLine("");

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }

    }
}