using System.Security.Cryptography;

public class Entry
{
    public string _date; // Value is still null - Ask Tutor's help
    public string _promptText;
    public string _entryText;    

    public void Display()
    {
        //gets the date from device's operating system
        DateTime newDate = new DateTime(); 

        // gets the random prompt form class PromptGenerator   
        PromptGenerator newPrompt = new PromptGenerator();
        _promptText = newPrompt.GetRandomPrompt();

        // print the date and random prompt
        // newDate returns 01/01/0001 - Ask Tutor's help
        Console.WriteLine($"Date: {newDate.ToString("MM/dd/yyyy")} - Prompt: {_promptText}");

        // receive the inputs from user
        _entryText = Console.ReadLine();        
    }
}