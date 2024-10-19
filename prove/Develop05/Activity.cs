public class Activity 
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected int _totalDuration = 0;
    protected int _totalRepetitions = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public Activity()
    {
        _name = "";
        _description = "";
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        _totalDuration += _duration;
        _totalRepetitions++;

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!\n");
        ShowSpinner(2);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {   
        List<string> spinnerString = new List<string>();
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");
        spinnerString.Add("|");
        spinnerString.Add("/");
        spinnerString.Add("-");
        spinnerString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerString[i]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if(i >= spinnerString.Count)
            {i = 0;}
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(seconds - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}