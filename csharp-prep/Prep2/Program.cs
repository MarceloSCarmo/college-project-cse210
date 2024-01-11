using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your grade percentage? ");
        string userInput = Console.ReadLine();

        // Converting string to int
        int percent = int.Parse(userInput);
        string letter;
        string sign;
        int lastDigite = percent % 10;

        // Conditions to each percent
        // GRADE A

        if (percent >= 90)
        {
            letter = "A";
            if (lastDigite < 3)
            {
                sign = "-";
                Console.WriteLine($"Grade {letter}{sign}");
            }
            else
            {
                Console.WriteLine($"Grade {letter}");
            }
        }
        // GRADE B
        else if (percent >= 80)
        {
            letter = "B";
            if (lastDigite >= 7)
            {
                sign = "+";
                Console.WriteLine($"Grade {letter}{sign}");
            }
            else if (lastDigite < 3)
            {
                sign = "-";
                Console.WriteLine($"Grade {letter}{sign}");
            }
            else
            {
                Console.WriteLine($"Grade {letter}");
            }
        }
        // GRADE C
        else if (percent >= 70)
        {
            letter = "C";
            if (lastDigite >= 7)
            {
                sign = "+";
                Console.WriteLine($"Grade {letter}{sign}");
            }
            else if (lastDigite < 3)
            {
                sign = "-";
                Console.WriteLine($"Grade {letter}{sign}");
            }
            else
            {
                Console.WriteLine($"Grade {letter}");
            }
        }
        // GRADE D
        else if (percent >= 60)
        {
            letter = "D";
            if (lastDigite >= 7)
            {
                sign = "+";
                Console.WriteLine($"Grade {letter}{sign}");
            }
            else if (lastDigite < 3)
            {
                sign = "-";
                Console.WriteLine($"Grade {letter}{sign}");
            }
            else
            {
                Console.WriteLine($"Grade {letter}");
            }
        }
        // GRADE F
        else
        {
            letter = "F";
            Console.WriteLine($"Grade {letter}");
        }
        // Add a separate if statement to determine if the user passed the course
        if (percent >= 70)
        {
            Console.Write("Congratulations, you passed the course.");
        }
        else 
        {
            Console.Write("Unfortunately you didn't pass the course, try once again.");
        }
    }
}