public class Summary
{
    private BreathingActivity _breathing;
    private ListingActivity _listing;
    private ReflectingActivity _reflecting;
    private int _totalDuration;
    private int _repetitions;
    
    public Summary(BreathingActivity breathing, ListingActivity listing, ReflectingActivity reflecting)
    {
        _breathing = breathing;
        _listing = listing;
        _reflecting = reflecting;
    }

    public void SetSummaryNumbers()
    {
        _totalDuration = _breathing.GetTotalDuration() + _listing.GetTotalDuration() + _reflecting.GetTotalDuration();
        _repetitions = _breathing.GetTotalRepetitions() + _listing.GetTotalRepetitions() + _reflecting.GetTotalRepetitions();
    }

    public void DisplaySummary()
    {
        Console.Clear();
        Console.WriteLine("/////////////////////////////////////");
        Console.WriteLine("///  Mindfulness session summary  ///");
        Console.Write("/////////////////////////////////////\n\n");

        SetSummaryNumbers();
        Console.WriteLine($"- Total of breathing exercises: {_breathing.GetTotalBeathingActivities()}");
        Console.WriteLine($"- Total of mindfulness excercise: {_totalDuration} seconds");
        Console.WriteLine($"- Total of activities: {_repetitions}");
        Console.WriteLine();
        Console.WriteLine("The following is list of the responses to the Listing activities\n");
        DisplayListing();
        Console.WriteLine("The following is list of the responses to the Reflecting activities\n");
        DisplayReflecting();

        Console.WriteLine("Press enter to return to the menu.");
        Console.ReadKey();
    }

    public void DisplayListing()
    {
        foreach (string str in _listing.GetSessionSummary())
        {
            Console.WriteLine(str);
        }
    }

    public void DisplayReflecting()
    {
        foreach (string str in _reflecting.GetSummary())
        {
            Console.WriteLine(str);
        }
    }

}