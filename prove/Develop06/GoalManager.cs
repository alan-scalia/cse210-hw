using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private bool _autoSave = false;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public int GetScore() { return _score; }
    public void SetScore(int score) { _score = score; }
    public void SetAutoSave()
    {
        if(_autoSave)
        {_autoSave = false;}
        else
        {_autoSave = true;}
    }
    public string GetAutoSave()
    {
        if(_autoSave)
        {return "Enable";}
        else
        return "Disable";
    }

    public void AutoSaveFile()
    {
        string fileName = "autosave.txt";
        SaveGoals(fileName);
    }

    public List<Goal> GetGoalList() { return _goals; }


    public void Start()
    {
        int option = 0;

        do
        {
            Console.WriteLine($"\nYou have {_score} points.\n");
            Console.Write("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\n\t7. Enable/Disable Autosave\nSelect a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string fileName = Console.ReadLine();
                    SaveGoals(fileName);
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    ListGoalNames();
                    RecordEvent();
                    break;
                case 6:
                    break;
                case 7:
                    SetAutoSave();
                    if(_autoSave){AutoSaveFile();}
                    Console.WriteLine($"Autosave is {GetAutoSave()}, file 'autosave.txt' can be load.");
                    break;
            }

        } while (option != 6);
    }
    public void DisplayPlayerInfo() { }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: \n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\n");
        System.Console.Write("Which type of goal would you like to create? ");
        int typeGoal = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDesc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        switch (typeGoal)
        {
            case 1:
                SimpleGoal newSimpleGoal = new SimpleGoal(goalName, goalDesc, points);
                _goals.Add(newSimpleGoal);
                break;
            case 2:
                EternalGoal newEternalGoal = new EternalGoal(goalName, goalDesc, points);
                _goals.Add(newEternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                ChecklistGoal newCheckListGoal = new ChecklistGoal(target, bonus, goalName, goalDesc, points);
                _goals.Add(newCheckListGoal);
                break;
        };
        if(_autoSave){
            AutoSaveFile();
        }
    }   
    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int accomplished = int.Parse(Console.ReadLine());

        _goals[accomplished - 1].RecordEvent();
        int points = _goals[accomplished - 1].GetPoints();
        _score += points;

        Console.Write($"Congratulations! You have earned {points} points!\nYou now have {_score} points.\n");
        
        if(_autoSave){
            AutoSaveFile();
        }
    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter($"{fileName}"))
        {
            outputFile.WriteLine(GetScore());
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals() 
    {
        System.Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        SetScore(int.Parse(lines[0]));
        lines[0] = "0:0";

    
        foreach(string line in lines)
        {
            string[] newLine = line.Split(":");
            if(newLine[0] == "SimpleGoal")
            {
                string[] goalParts = newLine[1].Split("|");

                SimpleGoal goal = new SimpleGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                goal.SetComplete(bool.Parse(goalParts[3]));

                _goals.Add(goal);
            }
            else if(newLine[0] == "EternalGoal")
            {
                string[] goalParts = newLine[1].Split("|");
                EternalGoal goal = new EternalGoal(goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                _goals.Add(goal);
            }
            else if(newLine[0] == "CheckListGoal")
            {
                string[] goalParts = newLine[1].Split("|");
                ChecklistGoal goal = new ChecklistGoal(int.Parse(goalParts[4]), int.Parse(goalParts[3]), goalParts[0], goalParts[1], int.Parse(goalParts[2]));
                goal.SetAmountCompleted(int.Parse(goalParts[5]));
                _goals.Add(goal);
            }

        }
    }
}