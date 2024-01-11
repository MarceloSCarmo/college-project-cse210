using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;

        // Generating a random number
        Random RandomNumberGenerator = new Random();
        int magicNumber = RandomNumberGenerator.Next(1,100);

        while (guess != magicNumber)
        {
            // This question will be made every time the while condition isn't satisfied
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