public class ListingActivity : Activity
{
    private int _count;
    private int _totalCount;
    private List<string> _prompts = new List<string>();
    private List<string> _userSession = new List<string>();

    public ListingActivity()
    {
        base._name = "Listing Activity";
        base._description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} --- ");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.WriteLine();

        //storing prompt of the session
        _userSession.Add($" --- {prompt} --- ");
        _userSession.Add("====================");
        _totalCount =+ _count;
        ///////////////////////////////
        
        GetListFromUser();
        Console.WriteLine($"You listed {_count} items!");
        base.DisplayEndingMessage();
        _count = 0;
        base._duration = 0;
    }

    public int GetTotalRepetitions() //returns the total of repetitions of each activity in the session.
    {
        return base._totalRepetitions;
    }

    public int GetTotalDuration() //returns the total duration, in secods, of all the sessions combnined.
    {
        return base._totalDuration;
    }

    public List<string> GetSessionSummary() //returns the complete list of excercises strings ready to print to console.
    {
        return _userSession;
    }

    public int GetTotalCount() //returns total count of inputs from the user.
    {
        return _totalCount;
    }

    public string GetRandomPrompt()
    {
        Random index = new Random();
        int i = index.Next(0, _prompts.Count);
        return _prompts[i];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> userInput = new List<string>();
        do
        {
            Console.Write("> ");
            userInput.Add(Console.ReadLine());
            _count++;
        } while (DateTime.Now < endTime);
        //Add all the responses to the session summary
        foreach (string i in userInput)
        {
            _userSession.Add($"> {i}");
        }
        _userSession.Add("====================\n\n");
        //////////////////////////////////////////////
        return userInput;
    }
}