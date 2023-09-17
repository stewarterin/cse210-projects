using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "Grade: B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "Grade: C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "Grade: D";
        }
        else if (grade < 60)
        {
            letter = "Grade: F";
        }
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time!");
        }
    }
}