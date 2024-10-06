using System;

//I added an "easy" mode at the beginning of the program wich will leave
//the first character of each word visible to make it easier to remember.

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Type 'easy' or 'hard' to pick the difficulty:");
        string difficulty = Console.ReadLine().ToLower();


        Console.Clear();
        Reference scriptureReference = new Reference("Proverbs", 3, 5, 6);
        string scriptureVerse = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        string[] verseWords = scriptureVerse.Split(' ');
        Scripture scripture = new Scripture(scriptureReference, scriptureVerse, difficulty);

        //Show Scripture
        
        bool finishProgram = false;
        do
        {
            Console.Clear();
            Console.Write(scripture.GetDisplayText());
    
            Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish:");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "":
                    Random rnd = new Random();
                    int wordCount = 0;
                    do
                    {
                        if (!scripture.IsCompletelyHidden())
                        {
                            int num = rnd.Next(verseWords.Count());
                            scripture.HideRandomWords(num);
                        }
                        else
                        {
                            wordCount = 3;
                            finishProgram = true;
                        }
                        wordCount++;
                    }while (wordCount < 3);
                    break;
                case "quit":
                    finishProgram = true;
                    break;
            }

        } while (finishProgram == false);
        
    }
}