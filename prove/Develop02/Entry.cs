using System.Security.Cryptography;

public class Entry
{
    public DateTime _date;
    public string _promptText;
    public string _entryText;    

    public void Display()
    {
        //gets the date from device's operating system
        DateTime newDate = new DateTime();
        _date = newDate.Date;

        // gets the random prompt form class PromptGenerator   
        PromptGenerator newPrompt = new PromptGenerator();
        _promptText = newPrompt.GetRandomPrompt();

        // print the date and random prompt
        // newDate returns 01/01/0001 - Ask Tutor's help
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");

        // receive the inputs from user
        _entryText = Console.ReadLine();        
    }
}