using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Creating a list of Activity objects
        List<Activity> activities = new List<Activity>();
        // Adding different activities to the list
        activities.Add(new Running("2025-10-15", 30, 3.0)); // 3 miles in 30 minutes
        activities.Add(new Cycling("2025-10-15", 45, 15.0)); // 15 mph for 45 minutes
        activities.Add(new Swimming("2025-10-015", 60, 30)); // 30 laps in 60 minutes

        // Iterating through the list and displaying summaries of each activity
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            // Or using ToString if overridden
            // Console.WriteLine(activity.ToString());
        }
    }
}