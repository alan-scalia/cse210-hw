// I have added a new class Summary which takes information from all the activities performed during a session
// and prints it in the console. To do that I have added methods and parameters to all the other classes.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        BreathingActivity Breathing = new BreathingActivity();
        ReflectingActivity Reflecting = new ReflectingActivity();
        ListingActivity Listing = new ListingActivity();

        Summary Summary = new Summary(Breathing, Listing, Reflecting);
        

        int option;

        do {
            Console.Clear();
            Console.Write("Menu Options:\n\t1. Start breathing activity\n\t2. Start reflecting activity\n\t3. Start listing activity\n\t4. Show session summary\n\t5. Quit\nSelect a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

        switch(option)
        {
            case 1:
                Breathing.Run();
                break;
            case 2:
                Reflecting.Run();
                break;
            case 3:
                Listing.Run();
                break;
            case 4:
                Summary.DisplaySummary();
                break;
            case 5:
                break;
        }
        }while(option != 5);

    }
    
}