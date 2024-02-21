
public class StationaryBicycles : Activity
{
    private double _speed;

    // Constructor
    public StationaryBicycles(DateTime date, int durationMinutes, double speed)
        : base(date, durationMinutes)
    {
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed; 
    }

    public override double GetPace()
    {
        return 60.0 / _speed; 
    }

   
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {_speed} kph, Pace: {GetPace()} min per km";
    }
}
