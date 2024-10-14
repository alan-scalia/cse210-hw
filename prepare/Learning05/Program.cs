using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment newMathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-9");
        Console.Write($"{newMathAssignment.GetSummary()}\n{newMathAssignment.GetHomeworkList()}");

        Console.Write("\n\n\n");

        WritingAssignment newWA = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.Write($"{newWA.GetSummary()}\n{newWA.GetWritingInfo()}");
    }
}