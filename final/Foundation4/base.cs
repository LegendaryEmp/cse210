//Base
public class Activity
{
    private DateTime _date;
    protected int _durationMinutes; 

    // Constructor
    public Activity(DateTime date, int durationMinutes)
    {
        this._date = date;
        this._durationMinutes = durationMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; 
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }


    public virtual string GetSummary()
    {
        return $"{_date.ToShortDateString()} - {GetType().Name} ({_durationMinutes} min)";
    }
}