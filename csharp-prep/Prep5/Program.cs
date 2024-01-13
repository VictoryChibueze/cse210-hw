using System;

class Program
{
    static void Main(string[] args)
    {
        // Calling the diplay welcome function
        DisplayWelcome();

        // calling the prompt user name 
        string aUserName = PromptUserName();

        // calling the prompt user number 
        int userNumber =  PromptUserNumber();

        // calling square number function

        int squaredNumber = SquareNumber(userNumber);


        // callling displaying message 
        DisplayResult(aUserName,squaredNumber);

    }
    //  Display welcome message function
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    // Prompt user name function
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;

    }
    //  Prompt user number function
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");

       string userNumber =  Console.ReadLine();

        int userNumberInt = int.Parse(userNumber);

        return userNumberInt;


    }
    // Square number function 
    static int SquareNumber(int number)
    {
        int squaredFavNumber = number * number ;

        return squaredFavNumber;

    }
    //  Display result functions 
    static void DisplayResult(string name, int squaredFavNumber)
    {
        Console.Write($"{name}, the square of the your number is {squaredFavNumber}");
    }
}