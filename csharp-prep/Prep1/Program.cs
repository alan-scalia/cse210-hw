using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string lastName;

        Console.Write("\nWhat is your first name? ");
        name = Console.ReadLine();
        Console.Write("What is your last name? ");
        lastName = Console.ReadLine();

        Console.Write($"\nYour name is {lastName}, {name} {lastName}.");
    }
}