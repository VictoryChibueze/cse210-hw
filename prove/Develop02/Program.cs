using System;

class Program
{
    static void Main(string[] args)
    {
        // Displaying prompt for the user of the jpurnal
       

        bool keepLooping = true;
        PromptGenerator promptGenerator1 = new PromptGenerator();
            
        Journal theJournal = new Journal();
       

        do
        {
             
            Entry entry = new Entry();
            
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");
            
         
            string userResponse = Console.ReadLine();
            int userResponseInt = int.Parse(userResponse);
            if (userResponseInt == 1)
            {
                entry._promptText = promptGenerator1.GetRandomPrompt();
                entry.Display();
                theJournal.AddEntry(entry);
                
            }else if (userResponseInt == 2)
            {
                theJournal.DisplayAll();
                
            }else if (userResponseInt == 3)
            {
                Console.WriteLine("Load");
                
            }else if(userResponseInt == 4)
            {
                Console.Write("filename: ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }else if(userResponseInt == 5)
            {
                keepLooping = false;
            }

            
            
        }while(keepLooping);
        
    }
}