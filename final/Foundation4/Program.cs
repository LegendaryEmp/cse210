using System;
using System.Collections.Generic;

// Base class Activity







class Program
{
    static void Main(string[] args)
    {
        // Create list to store activities
        List<Activity> activities = new List<Activity>();

        // Add activities to the list
        activities.Add(new Running(new DateTime(2024, 01, 01), 30, 3.0));
        activities.Add(new Running(new DateTime(2024, 01, 02), 30, 4.8));
        activities.Add(new StationaryBicycles(new DateTime(2024, 01, 03), 45, 25));
        activities.Add(new Swimming(new DateTime(2024, 01, 10), 60, 20));

        // Display summary for each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
