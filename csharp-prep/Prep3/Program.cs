using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int magicNumber = randomNumber.Next(1, 100);
        Console.WriteLine("Guess the magic number.");
        int guess = 0;

        do
        {
            Console.Write("What is your guess? ");
            string strGuess = Console.ReadLine();
            guess = int.Parse(strGuess);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (magicNumber != guess);
    }
}