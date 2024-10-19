public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        base._name = "Breathing Activity";
        base._description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        
        for (int i = 0; i < (base._duration / 10); i++)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            base.ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Now breath out...");
            base.ShowCountDown(6);
            Console.WriteLine();
        }
        
        base.DisplayEndingMessage();
        base._duration = 0;
    }

    public int GetTotalDuration() //returns the total duration, in secods, of all the sessions combnined.
    {
        return base._totalDuration;
    }

    public int GetTotalRepetitions() //returns the total of repetitions of each activity in the session.
    {
        return base._totalRepetitions;
    }

    public int GetTotalBeathingActivities() 
    {
        // returns the total of breathing exercises, taking in account that each 
        // exercise duration is 4s for BreathIn + 6sec for BreathOut
        return base._totalDuration / 10;
    }
}