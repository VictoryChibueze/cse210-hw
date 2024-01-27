using System;

class Program
{
    static void Main(string[] args)
    {
        // Displaying prompt for the user of the jpurnal
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.Write("What would you like to do? ");
        string userResponse = Console.ReadLine();
        int userResponseInt = int.Parse(userResponse);
        PromptGenerator promptGenerator1 = new PromptGenerator();
        
        Journal theJournal = new Journal();
        Entry entry = new Entry();

        do
        {
            entry._promptText = promptGenerator1.GetRandomPrompt();
            entry.Display();
            
        }while(userResponseInt ==1 );
        
    }
}