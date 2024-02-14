using System;

class Program
{
    static void Main(string[] args)
    {
        bool on = true;
        while(on){
            Console.WriteLine("Menu Option\n 1.Start breathing activity\n 2.Start reflecting activity\n 3.Start listing activity\n 4.Quit");
            Console.Write("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();
            int menuChoiceInt = int.Parse(menuChoice);
            Activity activity = new Activity("breathing","Goddd",2);
        
        switch (menuChoiceInt)
        {
            case 1:
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
                break;

            case 2:
                ReflectingActivity reflecting = new ReflectingActivity(); 
                reflecting.Run();   
                break;

            case 3:
                ListingActivity listing = new ListingActivity(0);
                listing.Run();
                break;

            case 4:
                on = false;  
                break;  
            
            default:
               break;
        }
       
        
        }


                
    }
}
// Exceeding requirement 
// Prompts are being loaded from a file Prompts.txt
// Questions are being loaded from a file ReflectionQuestion.txt
// Reflection prompts are being loaded from a file called ReflectionPrompts.txt