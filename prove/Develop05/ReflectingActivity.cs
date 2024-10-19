public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private List<int> _questionsAsked = new List<int>();
    private List<string> _sessionSummary = new List<string>();

    public ReflectingActivity()
    {
        base._name = "Reflecting Activity";
        base._description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }

    public void Run()
    {
        _questionsAsked = [];
        Console.Clear();
        base.DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();

        _questionsAsked.Add(-1); //add a negative integer to divide sessions.
        base.DisplayEndingMessage();
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

    public List<string> GetSummary() // returns  a list with all prompts and questions showed during excercises.
    {
        return _sessionSummary; //ready to print out in the console.
    }
 

    public string GetRandomPrompt()
    {
        Random index = new Random();
        int i = index.Next(0, _prompts.Count);

        return _prompts[i];
    }

    public string GetRandomQuestion()
    {
        bool repeated;
        int i;
        do
        {
            repeated = false;
            Random index = new Random();
            i = index.Next(0, _questions.Count);
            foreach(int num in _questionsAsked)
            {
                if (i == num)
                {
                    repeated = true;
                }
            }
            
        }while (repeated);
        _questionsAsked.Add(i);
        return _questions[i];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        // store prompt to the summary
        string prompt = GetRandomPrompt();
        _sessionSummary.Add($" --- {prompt} --- ");
        _sessionSummary.Add("====================");
        //////////////////////////////
        Console.WriteLine($"\n  --- {prompt} --- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.Clear();

        for(int i = 0; i < base._duration; i += 15)
        {
            //store each question to the session summary
            string question = GetRandomQuestion();
            _sessionSummary.Add($"> {question}");
            /////////////////////////////////////
            Console.Write($"> {question}");
            base.ShowSpinner(15);
            Console.WriteLine();
        }
        _sessionSummary.Add("====================\n\n");
    }
}