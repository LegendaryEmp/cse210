// Derived class for Swimming activity
public class Swimming : Activity
{
    private int _laps;

    // Constructor
    public Swimming(DateTime date, int durationMinutes, int laps)
        : base(date, durationMinutes)
    {
        this._laps = laps;
    }


    public override double GetDistance()
    {
        return _laps * 50.0 / 1000; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / (_durationMinutes / 60.0); 
    }

    public override double GetPace()
    {
        return _durationMinutes / GetDistance(); 
    }

   
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}