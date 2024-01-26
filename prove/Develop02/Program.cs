using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices");     

        // class promptGenerator
        PromptGenerator newPrompt = new PromptGenerator();
        Console.WriteLine(newPrompt.GetRandomPrompt());

        // class Entry
        Entry newEntry = new Entry();
        //newEntry._promptText = ; //a pergunta que foi feita aleatóriamente
        newEntry.Display(); // a resposta do usuário
        

        // class Journal
        Journal theJournal = new Journal();
        theJournal.AddEntry(newEntry);
        

        // 


        // 1. Bibliotecas Random & DateTime
        // 2. Criar uma lista e incluir várias perguntas nela. Essas perguntas
        // vão ser geradas aleatóriamente.
        // 3. Ter um menu com 5 opções.
        // 4. Salvar as respostas em um arquivo .txt.
        


    }
}