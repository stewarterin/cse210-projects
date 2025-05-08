using System;

//Create the resume class.
public class Resume
{
    //Create member variables.
    public string _name;
    public List<Job> _jobs = new List<Job>();

    //Create a method to display resume details.
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}