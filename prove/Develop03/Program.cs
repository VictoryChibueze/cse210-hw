using System;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //read scriptures from a file
        string filePath = "source.txt";
        string[] lines = File.ReadAllLines(filePath);
        Random random = new Random();
        int randomIndex = random.Next(lines.Length);
        string randomLine = lines[randomIndex];

        //parse random line into book, chapter, startVerse, endVerse, text by the 1st space and 2nd space
        int firstSpaceIndex = randomLine.IndexOf(" ");
        int secondSpaceIndex = randomLine.IndexOf(" ",firstSpaceIndex + 1);
        string book = randomLine.Substring(0,firstSpaceIndex);
        int chapter = int.Parse(randomLine.Substring(firstSpaceIndex +1 , 2));
        int startVerse = int.Parse(randomLine.Substring(firstSpaceIndex + 4, 2));
        
        string text = randomLine.Substring(secondSpaceIndex + 1);

        Console.WriteLine(randomLine);
        int counter = 0;

        bool keepLooping = true;
        
        
        do
        {
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();
            counter++;

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            // Assuming you have the Reference and Scripture classes implemented
             Reference reference = new Reference(book, chapter, startVerse);
            // Reference reference2 = new Reference(book, chapter, startVerse, endVerse);
            Scripture scripture = new Scripture(reference, text);
            scripture.HideRandomWords(counter);

            // Capture the result of GetDisplayText and print it to the console
            string displayText = scripture.GetDisplayText();
            Console.WriteLine(displayText);
            
           if (scripture.isCompletelyHidden()) {keepLooping = false;};
            
            

        } while (keepLooping);


// Exceeding requirement
// The program loads scriptures from a file known as source.txt
// Program randomly picks scriptures from the file
        

        
    }
};
