using System;
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

        Video video2 = new Video("I'm Batman!", "Bruce Wayne", 450);
        video1.AddComment("Alfred", "Very dramatic,sir.");
        video1.AddComment("Commissioner Gordon", "No sightings,just shadows");
        video1.AddComment("Robin", "Wait...you're Batman?");
        video1.AddComment("Joker", "Why so serious???");

        Video video3 = new Video("How fast can I run?", "Barry Allen", 330);
        video1.AddComment("Iris West Allen", "You are literally lightning.");
        video1.AddComment("Wally West", "There is no way you can beat me!");
        video1.AddComment("Harrison Wells", "Run, Barry, Run.");
        video1.AddComment("Zoom", "I will destroy you!!!");

        foreach (var video in videos)
        {
            Console.WriteLine($"{video.Title} by {video.Author} Video length:({video.Length}seconds)");

            foreach (var comment in video.comments)
            {
                Console.WriteLine(comment)
            }
        }
    }
}