
using System;

class Program
{
    static void Main(string[] args)
    {
        
        GoalManager manager = new GoalManager();
        bool run = true;
        bool quit;

        do
        {
            manager.Start();

            Console.Write("Are you sure you want to quit? (yes/no)\n>  ");
            string response = Console.ReadLine();

            do
            {
                quit = true;

                if (response.ToLower() == "yes")
                {
                    run = false;
                    Console.WriteLine("\nThanks, have a wonderful day");
                }
                else if (response.ToLower() == "no")
                {
                    run = true;
                }
                else
                {
                    Console.Write("Invalid response, choose between (yes) and (no)\n>");
                    response = Console.ReadLine();
                    quit = false;
                }
            } while (!quit);

        } while (run);
    }
}