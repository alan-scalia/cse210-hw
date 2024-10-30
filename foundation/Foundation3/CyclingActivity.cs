public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(float speed, string date, float length) : base(date, "Swimming", length)  {
        _speed = speed;
    }

    public void SetSpeed(float speed) {
        _speed = speed;
    }
    public override float CalculateSpeed(){
        return _speed;
    }

    public override float CalculateDistance()
    {
        return CalculateSpeed() * GetLength();
    }

    public override float CalculatePace()
    {
        return 60f / CalculateSpeed();
    }
}