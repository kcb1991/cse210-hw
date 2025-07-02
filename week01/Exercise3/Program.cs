using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);
        int guessInt = -1;
        
        
        while (guessInt != magicNumber)
        {
            Console.Write("What is the guess? ");
            guessInt = int.Parse(Console.ReadLine());
            if (magicNumber > guessInt)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessInt)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.Write("Great job! You guessed it right.");
            }
        }
    }
}