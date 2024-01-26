using System.Security.Cryptography;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;    

    public void Display()
    {
        DateTime _date = new DateTime(); 
        Console.WriteLine(_date.ToString("MM/dd/yyyy"));
        
        PromptGenerator _promptText = new PromptGenerator();
        string newPrompt = _promptText.GetRandomPrompt();

        
    }
}