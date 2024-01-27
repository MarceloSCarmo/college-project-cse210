public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Methods below
    public void AddEntry(Entry newEntry)
    {
        // class Entry.
        //Show the user a random prompt (from a list), and save 
        //their response, the prompt, and the date as an Entry.
        Entry userEntry = new Entry();
        userEntry.Display();
    }
    public void DisplayAll() // Display
    // Iterate through all entries in the journal and display them to the screen
    {
        // print a _entries list
        foreach (Entry entry in _entries)
            {
                Console.WriteLine(entry);
            }
    }
    public void SaveToFile(string File) // Save
    // 
    {

    }
    public void LoadFromFile(string File) // Load
    {

    }

}
