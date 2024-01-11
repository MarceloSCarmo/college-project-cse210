using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;

        Random RandomNumberGenerator = new Random();
        int magicNumber = RandomNumberGenerator.Next(1,100);

        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            string userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }   
        } 

    }
}