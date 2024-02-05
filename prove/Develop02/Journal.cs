using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    static Entry AddEntryToList()
    {
        Entry userEntry = new Entry();
        userEntry.WriteEntry();
        return userEntry;
    }

    // Methods below
    public void AddEntry(Entry newEntry)
    {
        // class Entry.
        //Show the user a random prompt (from a list), and save 
        //their response, the prompt, and the date as an Entry.
        //Entry userEntry = new Entry();
        //userEntry.WriteEntry();

        Entry newList = AddEntryToList();
    }
    public void DisplayAll() // Display
    // Iterate through all entries in the journal and display them to the screen
    {   
        
        foreach(Entry i in _entries)
        {
            Console.WriteLine(i);
        }
        // print a _entries list
    }

    public void SaveToFile(string File) // Save
    // 
    {
        //Console.WriteLine("Saving to file...");

        //string fileName = "myJournal.CSV";

        //using (StreamWriter outputFile = new StreamWriter(fileName))
        //{
        //    foreach(Entry entry in _entries)
        //    {
                // You can add text to the file with the WriteLine method
        //        outputFile.WriteLine("This will be the first line in the file.");
                
                // You can use the $ and include variables just like with Console.WriteLine
        //        string color = "Blue";
        //        outp'utFile.WriteLine($"My favorite color is {color}");
        //    }
        //}
    }
    public void LoadFromFile(string File) // Load
    {

    }

}
