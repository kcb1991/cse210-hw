using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        Activity activity = null;

        while (activity == null && choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Please select a new activity to help you.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            choice = Console.ReadLine();

            activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectingActivity(),
                "3" => new ListingActivity(),
                "4" => null,
                _ => null
            };

            if (activity == null && choice != "4")
            {
                Console.WriteLine("Invalid selection — please make a choice 1–3.");
                Thread.Sleep(2000); // Give user time to read the message
            }
        }
        if (choice == "4")
        {
            Console.WriteLine("Thanks for using the Mindfulness Program. Take care!");
        }
        else
        {
            Console.Clear();
            activity.Run();
        }


    }
}