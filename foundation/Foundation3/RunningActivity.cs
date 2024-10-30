public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(float distance, string date, float length) : base(date, "Running", length)  {
        _distance = distance;
    }

    public void SetDistance(float distance){
        _distance = distance;
    }
    public override float CalculateDistance(){
        return _distance;
    }

    public override float CalculateSpeed()
    {
        return _distance / GetLength() * 60.0f;
    }

    public override float CalculatePace()
    {
        return GetLength() / _distance;
    }
}