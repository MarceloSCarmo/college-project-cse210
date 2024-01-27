using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

class Program
{
    private static int newUserPrompt; // Show this variable to the tutor

    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices");     

        //Provide a menu that allows the user choose these options(Journal class)
        List<string> _menu = new List<string>();
        _menu.Add("Write");
        _menu.Add("Display");
        _menu.Add("Save");
        _menu.Add("Load");
        _menu.Add("Quit");
        
        // Creating an object to access Journal class
        Journal theJournal = new Journal();  

        Entry userEntry = new Entry();

        do
        {
            int count = 1;
            foreach (string options in _menu)
            {
                // Display the menu
                Console.WriteLine($"{count}. {options}");
                count ++;
            }

            //receive prompt from the user
            Console.Write("What would you like to do? ");
            string newUserPrompt = Console.ReadLine();
            int userPrompt = int.Parse(newUserPrompt);            

            if (userPrompt == 1)
            {    
                userEntry.Display();
                theJournal._entries.Add(userEntry);
            }
            else if (userPrompt == 2)
            {
                theJournal.DisplayAll();
            }     
            else if (userPrompt == 3)
            {
                //Console.WriteLine(SaveToFile);
            }
            else if (userPrompt == 4)
            {
                //Console.WriteLine(LoadFromFile);
            }           
        }
        while (newUserPrompt < 5); 
    }
}