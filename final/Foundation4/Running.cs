// Derived class for Running activity
public class Running : Activity
{
    private double _distanceMiles;

    // Constructor
    public Running(DateTime date, int durationMinutes, double distanceMiles)
        : base(date, durationMinutes)
    {
        this._distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        return _distanceMiles / (_durationMinutes / 60.0); 
    }


    public override double GetPace()
    {
        return _durationMinutes / _distanceMiles; 
    }


    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {_distanceMiles} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}