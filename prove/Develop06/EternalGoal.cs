public class EternalGoal : Goal
{

    public EternalGoal(string name, string desc, int points) : base(name, desc, points){}

    public override void RecordEvent(){} //nothing to complete
    public override bool IsComplete(){return false;} //it's allways false
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{base.GetShortName()}|{base.GetDescription()}|{base.GetPoints()}";
    }
}