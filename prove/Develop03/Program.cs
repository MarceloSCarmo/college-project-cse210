uusing System.Collections.Generic;

public class PromptGenerator
{
    // Attributes
    public List<string> _prompts = new List<string>();

    //Method below
    public string GetRandomPrompt()
    {
        //ter os prompts
        //mostrar de forma aleatória
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

       // foreach(string prompt in _prompts)
        //{
        Random randomPrompt = new Random();
        string prompt = _prompts[randomPrompt.Next(_prompts.Count)];
        //}
        return "";
        
    }

    
}