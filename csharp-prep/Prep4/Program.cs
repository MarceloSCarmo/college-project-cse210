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

        // variable holds the largest number in the list
        int largest = 0;

        int smallest = 1000000000;

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
                

                // finding the largest number in the list
                if (number > largest)
                {
                    largest = number;
                }

                // finding the smallest positive number in the list
                if (number < smallest && number > 0)
                {
                    smallest = number;
                }
            }
        }
        Console.WriteLine($"The sum is: {count}");

        float average = count / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine();

        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        
        // Sort the numbers in the list and display the new, sorted list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
    }
}