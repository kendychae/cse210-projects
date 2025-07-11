using System;

class Program
{
    static void Main(string[] args)
    {
        // Test the base Assignment class
        Assignment simpleAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine();

        // Test the MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // Test the WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}