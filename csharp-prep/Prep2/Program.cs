using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int percentage = int.Parse(userInput);
        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80 && percentage < 90)
        {
            grade = "B";
        }
        else if (percentage >= 70 && percentage < 80)
        {
            grade = "C";
        }
        else if (percentage >= 60 && percentage < 70)
        {
            grade = "D";
        }
        else if (percentage < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade: {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations, you've passed.");
        }
        else
        {
            Console.WriteLine("You have not passed. Good luck next time.");
        }
    }
}