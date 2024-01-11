using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        // Will sum the amount of numbers
        float count = 0;

        // largest number
        int largest = 0;

        // creating a list of numbers
        List<int> numbers = new List<int>();

        for (int number = -1; number != 0; count = count + number)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");  
            string userInput = Console.ReadLine();
            
            // converting string into int
            number = int.Parse(userInput);
            // adding itens to the list
            if (number != 0)
            {
                numbers.Add(number);
                
                if (number > largest)
                {
                    largest = number;
                }
            }
        }
        Console.WriteLine($"The sum is: {count}");

        float average = count / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine();

        Console.WriteLine($"The largest number is: {largest}");
    }
}