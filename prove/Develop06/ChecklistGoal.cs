public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(int target, int bonus, string name, string desc, int points) : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted(){return _amountCompleted;}
    public void SetAmountCompleted(int amount){_amountCompleted = amount;}
    public int GetTarget(){return _target;}
    public void SetTarget(int target){_target = target;}
    public int GetBonus(){return _bonus;}
    public void SetBonus(int bonus){_bonus = bonus;}




    public override void RecordEvent()
    {
        _amountCompleted++;
        if(IsComplete())
        {
            base.SetPoints(_bonus);
        }
        
    }
    public override bool IsComplete()
    {
        if(GetTarget() == GetAmountCompleted())
        {
            return true;
        }    
        return false;
    }
    public override string GetDetailsString()
    {
        string complete = " ";
        if(IsComplete())
        {
            complete = "X";
        }
        return $"[{complete}] {base.GetShortName()} ({base.GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()}";
    }
    public override string GetStringRepresentation()
    {
        return $"CheckListGoal:{base.GetShortName()}|{base.GetDescription()}|{base.GetPoints()}|{GetBonus()}|{GetTarget()}|{GetAmountCompleted()}";
    }
}