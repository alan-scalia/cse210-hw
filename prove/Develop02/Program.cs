//For the exceeding requirements, I have added a method to PromptGenerator class so the user can add extra prompts to
//the list which is used to write a new Entry. I have stored the list of prompts in a .txt file so the new prompts added
//by the user are available every time they load the journal.

using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to the Journal Program!");
        Journal Journal1 = new Journal();
        string option;
        //Program loop.
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Add Prompt\n6. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
            switch (option)
            {
                
                case "1":
                    //Write: instantiates Entry class and uses AddEntry method to store it.
                    Entry newEntry = new Entry();
                    Journal1.AddEntry(newEntry);
                    break;
                case "2":
                    //Display: uses DisplayAll method to display all the entries of the journal.
                    Journal1.DisplayAll();
                    break;
                case "3":
                    //Load: takes input from the user and calls the LoadFromFile method from the journal
                    Console.Write("What is the file name? ");
                    string loadFileName = Console.ReadLine();
                    Journal1.LoadFromFile(loadFileName);
                    break;
                case "4":
                    //Save: takes input from the user and creates a file with the entries stored in the journal.
                    Console.Write("What is the file name? ");
                    string saveFileName = Console.ReadLine();
                    Journal1.SaveToFile(saveFileName);
                    break;
                case "5":
                    //Add Prompt: instantiates the PromptGenerator and calls the AddPrompt method to store a new prompt.
                    PromptGenerator addPrompt = new PromptGenerator();
                    addPrompt.AddPrompt();
                    break;
                case "6":
                    //Quit.
                    break;
                default:
                    //Handle input errors.
                    Console.WriteLine("Please enter a valid option.");
                    break;
            }
        } while (option != "6");
        
    }
}