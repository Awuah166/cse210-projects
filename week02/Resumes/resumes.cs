using System;

public class Resumes
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void DisplayJobDetails()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Jobs: ");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}