using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userResponse = Console.ReadLine();
        int gradePercent = int.Parse(userResponse);
        string letterGrade;

        if (gradePercent >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercent >= 80)
        {
            letterGrade = "B";
        }
        else if (gradePercent >= 70)
        {
            letterGrade = "C";
        }
        else if (gradePercent >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations! you have passed the class.");
        }
        else
        {
            Console.WriteLine("You haven't pass the class. Don't worry! you can always try one more time :)");
        }

        if (gradePercent < 97 && gradePercent >= 60)
        {
            if (gradePercent % 10 >= 7)
            {
                letterGrade = letterGrade + "+";
            }
            else if (gradePercent % 10 < 3)
            {
                letterGrade = letterGrade + "-";
            }
        }

        Console.WriteLine($"Your grade is: {letterGrade}");

    }
}