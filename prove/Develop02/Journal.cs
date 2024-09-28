public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) 
    {
        //Store date in the new Entry object.
        string[] date = DateTime.Today.ToString().Split(" ");
        newEntry._date = date[0];
        //Instatiate PromptGenerator and store the prompt in Entry object.
        PromptGenerator prompt = new PromptGenerator();
        newEntry._promptText = prompt.GetRandomPrompt();
        //Display the prompt and store the entry text in the object.
        Console.WriteLine(newEntry._promptText);
        Console.Write(">");
        newEntry._entryText = Console.ReadLine();
        
        //Stores the new entry;
        _entries.Add(newEntry);
    }

    public void DisplayAll() 
    {
        //Display the Journal.
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}\n\n");
        }
    }

    public void SaveToFile(string file) 
    {
        using (StreamWriter journalFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                journalFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

    }

    public void LoadFromFile(string file) 
    {
        string[] loadFile = System.IO.File.ReadAllLines(file);
        foreach (string entry in loadFile)
        {
            string[] section = entry.Split("|");

            Entry newEntry = new Entry();

            newEntry._date = section[0];
            newEntry._promptText = section[1];
            newEntry._entryText = section[2];

            _entries.Add(newEntry);
        }
    }
}