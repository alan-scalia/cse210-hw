using System;

class Program
{
    static void Main(string[] args)
    {
        string[] date = DateTime.Today.ToString().Split(" ");
        Console.Write(date[0]);
    }
}