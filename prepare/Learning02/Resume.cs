using System;

// Create the Resume class.
public class Resume
{
    //Create the member variables for the Resume class.
    public string _name;
    public List<Job> _jobs = new List<Job>();

    // Create a method to display the resume details. 
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _jobs)
        {
           job.DisplayJobDetails();
        }
        
    }
}