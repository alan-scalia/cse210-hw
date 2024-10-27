public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {}

    public void SetComplete(bool complete){_isComplete = complete;}
    public override bool  IsComplete(){return _isComplete;}

    public override void RecordEvent()
    {
        if(!IsComplete())
        {
            SetComplete(true);
        }
    }
    
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{base.GetShortName()}|{base.GetDescription()}|{base.GetPoints()}|{IsComplete()}";
    }
}