using System;

// Create the Job class.
public class Job
{
    // Create the member variables for the Job class.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    // Create a method to display the job details.
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}