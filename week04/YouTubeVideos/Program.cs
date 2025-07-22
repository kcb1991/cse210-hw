using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Krypton:My Home Planet", "Clark Kent", 720);
        video1.AddComment("Jor-El", "Your planet was truly beautiful.");
        video1.AddComment("Lois Lane", "So heartfelt, Clark.");
        video1.AddComment("Jimmy Olsen", "What kind of camera did you use?");
        video1.AddComment("Perry White", "Get back to work Clark!");
        videos.Add(video1);

        Video video2 = new Video("I'm Batman!", "Bruce Wayne", 450);
        video2.AddComment("Alfred", "Very dramatic,sir.");
        video2.AddComment("Commissioner Gordon", "No sightings,just shadows");
        video2.AddComment("Robin", "Wait...you're Batman?");
        video2.AddComment("Joker", "Why so serious???");
        videos.Add(video2);

        Video video3 = new Video("How fast can I run?", "Barry Allen", 330);
        video3.AddComment("Iris West Allen", "You are literally lightning.");
        video3.AddComment("Wally West", "There is no way you can beat me!");
        video3.AddComment("Harrison Wells", "Run, Barry, Run.");
        video3.AddComment("Zoom", "I will destroy you!!!");
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"{video.Title} by {video.Author} Video length:({video.Length} seconds)");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment);
            }
        }
    }
}