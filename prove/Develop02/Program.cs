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
            string userPrompt = Console.ReadLine();
            int newUserPrompt = int.Parse(userPrompt);

            //Journal theJournal = new Journal();     
            if (newUserPrompt == 1)
            {    
                //console.WriteLine(AddEntry);
            }
            else if (newUserPrompt == 2)
            {
                //console.WriteLine(Display);
            }     
            else if (newUserPrompt == 3)
            {
                //console.WriteLine(SaveToFile);
            }
            else if (newUserPrompt == 4)
            {
                //console.WriteLine(LoadFromFile);
            }           
        }
        while (newUserPrompt < 5);

        // class Journal
        //Journal theJournal = new Journal();
        //theJournal.AddEntry(newEntry);       

    }
}