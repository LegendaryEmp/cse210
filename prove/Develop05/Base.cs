abstract class Activity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Value { get; set; }

    public Activity(string name, string description, int value)
    {
        Name = name;
        Description = description;
        Value = value;
    }

    public abstract bool IsCompleted();
    public abstract void RecordEvent();
    public virtual void DisplayDetails(int index)
    {
        Console.WriteLine($"[{(IsCompleted() ? "X" : " ")}] {index}  {Name} ({Description})");
    }

    public override string ToString()
    {
        return $"{GetType().Name},{Name} ({Description}),Value:{Value}";
    }
}