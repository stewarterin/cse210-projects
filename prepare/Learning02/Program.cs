using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new job instance named job1.
        Job job1 = new Job();

        // Set the member variables for job1. 
        job1._company = "Marshall Industries Inc.";
        job1._jobTitle = "Project Manager";
        job1._startYear = 2012;
        job1._endYear = 2023;

        // Create another job instance named job2.
        Job job2 = new Job();

        // Set the member variables for job2.
        job2._company = "Smith & Carson";
        job2._jobTitle = "Public Records Research Assistant";
        job2._startYear = 2000;
        job2._endYear = 2010;

        // Create a new resume instance named myResume.
        Resume myResume = new Resume();

        // Set the member variable.
        myResume._name = "Jane Doe";

        // Add job1 and job2 to the list of jobs in the resume object.
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume details by calling the DisplayResume method.
        myResume.DisplayResume();
    }
}