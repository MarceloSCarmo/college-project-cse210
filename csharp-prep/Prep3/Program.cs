using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);

        string userGuess;
        int guess = 0;


        while (guess != magicNumber)
        {
            Console.WriteLine("What is your guess?");
            userGuess = Console.ReadLine();
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