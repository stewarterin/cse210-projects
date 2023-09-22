using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int magicNum = int.Parse(magic);

        int guessNum = -1;
        
        while (guessNum != magicNum)
        {
            Console.Write("What is your guess? ");
            guessNum = int.Parse(Console.ReadLine());
        
            if (guessNum > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNum < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else 
                Console.WriteLine("You guessed it!");
        }
    }
}