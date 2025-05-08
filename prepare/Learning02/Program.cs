using System;

class Program
{
    static void Main(string[] args)
    {
        //New job instance.
        Job job1 = new Job();

        //Set member variables for job1.
        job1._company = "Google";
        job1._jobTitle = "Softwarwe Engineer";
        job1._startYear = "2020";
        job1._endYear = "2025";

        //New job instance.
        Job job2 = new Job();

        //Set member variables for job2.
        job2._company = "Dell";
        job2._jobTitle = "Project Manager";
        job2._startYear = "2011";
        job2._endYear = "2019";

        //New resume instance.
        Resume myResume = new Resume();

        //Set member variable for name.
        myResume._name = "Erin Stewart";

        //Add job1 and job2 to list of jobs in resume object. 
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Call DisplayResume method from Resume class.
        myResume.DisplayResume();
    }
}