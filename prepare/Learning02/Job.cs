using System;

//Create the job class.
public class Job
{
    //Create member variables.  
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    //Create a method to display job details. 
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}