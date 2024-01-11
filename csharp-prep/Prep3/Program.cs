using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // This inital condition will make the game starts
        string playAgain = "yes";

        do
        {
            // Generating a random number
            Random RandomNumberGenerator = new Random();
            int magicNumber = RandomNumberGenerator.Next(1,100);

            // count the number of guesses
            int count = 0;
            // recieves the intial guess, it will alwyas be different from the magicNumber
            int guess = 0;

            while (guess != magicNumber)
            {
                count ++;

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
            Console.WriteLine($"It took {count} guesses");
            
            Console.WriteLine("Would you like to play again?");
            playAgain = Console.ReadLine();

        } while (playAgain.ToUpper() == "YES");

    }
}