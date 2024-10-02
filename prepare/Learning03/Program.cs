using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the top number: ");
        int topNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter the bottom number: ");
        int bottomNumber = int.Parse(Console.ReadLine());

        Fraction defaultFraction = new Fraction();
        Fraction topFraction = new Fraction(topNumber);
        Fraction classicFraction = new Fraction(topNumber, bottomNumber);

        Console.WriteLine(defaultFraction.GetFractionString());
        Console.WriteLine(topFraction.GetFractionString());
        Console.WriteLine(classicFraction.GetFractionString());

        Console.WriteLine(defaultFraction.GetDecimalValue());
        Console.WriteLine(topFraction.GetDecimalValue());
        Console.WriteLine(classicFraction.GetDecimalValue());
    }
}