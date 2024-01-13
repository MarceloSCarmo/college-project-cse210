using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }

    // Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    // Asks for and returns the user's name (as a string)
    static string PromptUserName(string userName)
    {
        Console.WriteLine("What is your name?");
        userName = Console.ReadLine();
        return userName;
    }

    // Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber(string userFavoriteNumber)
    {
        Console.WriteLine("What is your name?");
        userFavoriteNumber = Console.ReadLine();
        // Converting string to int
        int FavoriteNumber = int.Parse(userFavoriteNumber);

        return FavoriteNumber;
    }
}