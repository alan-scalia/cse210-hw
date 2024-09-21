using System;
using System.Net;

class Program
{
    static void DisplayWelcome () 
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName () 
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber() 
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());

        return userNumber;
    }
    static int SquareNumber (int userNumber)
    {
        int square = userNumber * userNumber;

        return square;
    }
    static void DisplayResult (string userName, int userSquareNumber) 
    {
        Console.Write($"{userName}, the square of your number is {userSquareNumber}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);
    }
}