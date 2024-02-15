class ChecklistGoal : Activity
{
    private int recorded;
    private int timesToAccomplish;

    public int Recorded
    {
        get { return recorded; }
        set { recorded = value; }
    }

    public ChecklistGoal(string name, string description, int value, int timesToAccomplish) : base(name, description, value)
    {
        this.timesToAccomplish = timesToAccomplish;
        recorded = 0;
    }

    public override bool IsCompleted()
    {
        return recorded >= timesToAccomplish;
    }

    public override void RecordEvent()
    {
        recorded++;
    }

    public override void DisplayDetails(int index)
    {
        base.DisplayDetails(index);
        Console.WriteLine($" -- currently completed: {recorded}/{timesToAccomplish}");
    }

    public override string ToString()
    {
        return $"{GetType().Name},{Name} ({Description}),Value:{Value},Recorded:{recorded}/{timesToAccomplish}";
    }
}