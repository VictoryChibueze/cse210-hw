using System;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        // Prompting the user for his/her first name
        Console.Write("What is your first name? ");
        // Saving the first name of the user in a variable
        string fname = Console.ReadLine();

        // Prompting the usre for his/her last name 
        Console.Write("What is your last name? ");
        // Saving the last name of the user in a variable
        string lname = Console.ReadLine();

        Console.Write(" ");

        // Displaying the fullname of the user

        Console.WriteLine($"Your name is {lname}, {fname} {lname}");




    }
}