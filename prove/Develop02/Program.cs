using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices");     

        // class Entry
        Entry newEntry = new Entry();
        newEntry.Display();   
        
        // class Journal
        Journal theJournal = new Journal();
        theJournal.AddEntry(newEntry);       

    }
}