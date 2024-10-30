using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity running = new RunningActivity(4.8f, "03 Nov 2024", 30f);
        SwimmingActivity swimming = new SwimmingActivity(5f, "30 Oct 2024", 30f);
        CyclingActivity cycling = new CyclingActivity(20f, "01 Jan 2022", 45);

        List<Activity> activities = new List<Activity>();

        activities.Add(cycling);
        activities.Add(running);
        activities.Add(swimming);

        System.Console.Clear();
        foreach (Activity act in activities)
        {
            Console.WriteLine(act.DisplaySummary());
        }

    }
}