


public class Resume{
    //responsibilities
    public string _name;
    public  List<Job> _jobs = new List<Job>();

    //Behaviour
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        //loop
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}



