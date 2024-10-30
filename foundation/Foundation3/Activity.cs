public abstract class Activity
{
    private string _date;
    private float _length;
    private string _activityName;
    

    public Activity(string date, string activityName, float length) {
        _date = date;
        _activityName = activityName;
        _length = length;
    }

    public void SetDate(string date) {
        _date = date;
    }
    public string GetDate(){
        return _date;
    }

    public void SetLength(int length) {
        _length = length;
    }
    public float GetLength() {
        return _length;
    }

    public void SetActivityName(string name){
        _activityName = name;
    }
    public string GetActivityName() {
        return _activityName;
    }

    public string DisplaySummary(){
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return $"{GetDate()} {GetActivityName()} ({GetLength()} min): Distance {Math.Round(CalculateDistance(), 2)} km, Speed: {Math.Round(CalculateSpeed(), 2)}kph, Pace: {Math.Round(CalculatePace(), 2)} min per km";
    }

    public virtual float CalculateSpeed(){
        return 0f;
    }
    public virtual float CalculatePace(){
        return 0f;
    }
    public virtual float CalculateDistance(){
        return 0f;
    }
}
