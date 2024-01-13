using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        string userFavoriteNumber = Console.ReadLine();
        // Converting string to int
        int FavoriteNumber = int.Parse(userFavoriteNumber);

        return FavoriteNumber;
    }

    // Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int FavoriteNumber)
    {
        int square = FavoriteNumber * FavoriteNumber;

        return square;
    }

    // Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string userName, int square)
    {
        Console.WriteLine($"{userName}, the square of your number is {square}");
    }
}