public class PromptGenerator 
{
    public List<string> _prompts;
    public string _promptsFile = "prompts.txt"; //filename where prompts are stored.

    public string GetRandomPrompt()
    {
        //Read from file and store into an array of strings.
        string[] promptsArray = System.IO.File.ReadAllLines(_promptsFile);
        //Instantiate Random class.
        Random rand = new Random();
        //Generates a random number to select a random string from the array.
        string randomPrompt = promptsArray[rand.Next(0, promptsArray.Count() - 1)];
        //return the random string.
        return randomPrompt;
    }

    public void AddPrompt()
    {
        //Asks for the prompt the user wants to add to the list and stores it in a string.
        Console.Write("Please enter the prompt you want to add: ");
        string newPrompt = Console.ReadLine();
        //Opens the file, stores the prompt at the end of it and closes the file.
        StreamWriter writePrompt = new StreamWriter(_promptsFile, append: true);
        writePrompt.WriteLine(newPrompt);
        writePrompt.Close();
    }

}