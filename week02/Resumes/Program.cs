using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2024;
        job2._endYear = 2025;


        Resumes myResume = new Resumes();
        myResume._personName = "Awuah Dennis";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Displaying the job details on the screen
        myResume.DisplayJobDetails();

    }
}