using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magic = int.Parse(Console.ReadLine());

        int guess = -1;

        Random randomNumber = new Random();
        int magic = randomNumber.Next(1, 100);

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
                Console.WriteLine("You guessed it!");
        }
    }
}