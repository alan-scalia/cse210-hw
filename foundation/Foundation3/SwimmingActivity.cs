public class SwimmingActivity : Activity
{
    private float _lapsNumber;

    public SwimmingActivity(float lapsNumber, string date, float length) : base(date, "Swimming", length)  {
        _lapsNumber = lapsNumber;
    }

    public void AddLapsNumber(int laps){
        _lapsNumber += laps;
    }
    public float GetLapsNumber(){
        return _lapsNumber;
    }


    public override float CalculateDistance()
    {
        return _lapsNumber * 50f / 1000f;
    }

    public override float CalculateSpeed()
    {
        return CalculateDistance() / GetLength() * 60f;
    }

    public override float CalculatePace()
    {
        return GetLength() / CalculateDistance();
    }
}