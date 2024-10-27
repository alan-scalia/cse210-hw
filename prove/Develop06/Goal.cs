public abstract class Goal 
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string name, string desc, int points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public string GetShortName(){return _shortName;}
    public void SetShortName(string name){_shortName = name;}
    public string GetDescription(){return _description;}
    public void SetDescription(string desc){_description = desc;}
    public int GetPoints(){return _points;}
    public void SetPoints(int points){_points += points;}


    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string complete = " ";
        if(IsComplete())
        {
            complete = "X";
        }
        return $"[{complete}] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}