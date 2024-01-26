using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Please select one of the following choices");
        // Console.WriteLine("1.Write");

        // Console.WriteLine("2.Display");
        // Console.WriteLine("3.Load");
        // Console.WriteLine("4.Save");
        // Console.WriteLine("5.Quit");
        // string quit = Console.ReadLine();
        // int quitInt = int.Parse(quit);

        // string write = Console.ReadLine();
        // int writeInt = int.Parse(write);
        // string display = Console.ReadLine();
        // int displayInt = int.Parse(display);
        // string load = Console.ReadLine();
        // int loadInt = int.Parse(load);
        // string save = Console.ReadLine();
        // int saveInt = int.Parse(save);

        PromptGenerator promptGenerator1 = new PromptGenerator();
        promptGenerator1.GetRandomPrompt();

    }
}