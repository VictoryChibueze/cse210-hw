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
                ListingActivity listing = new ListingActivity(10,"listing","reflect on the good things in your life by having you list as many things as you can in a certain area.",30);
                listing.DisplayStartingMessage();
                listing.DisplayEndingMessage();
                break;



            case 3:
                break;

            case 4:
                on = false;  
                break;  
            
            default:
               break;
        }
       
        
        }
                             // ReflectingActivity reflectingActivity = new ReflectingActivity("reflecting","reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",30);


                
    }
}
// "This activity will help you 'relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."
// "This activity will help you 'reflect on the good things in your life by having you list as many things as you can in a certain area."
// "This activity will help you 'reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
