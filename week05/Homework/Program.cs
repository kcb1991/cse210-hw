using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        WritingAssignment english1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(english1.GetSummary());
        Console.WriteLine(english1.GetWritingInformation());

    }
}