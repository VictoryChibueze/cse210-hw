using System;
using System.Collections.Generic;
using System.Data.Common;

class Program
{
    static void Main(string[] args)
    {
        // Displaying a welcome instruction to the user
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        
        string keepTheLoop = "yes";
        // Initializing the sum and average variable
        float sum = 0;
        float average = 0;

        // intialization of the list data structure
        List<float> enteredNumberList = new List<float> ();

        // initializing the list count variable
        int listCount = 0;

        // loop for prompting the user to enter numbers until zero is entered to exist the loop
        while(keepTheLoop =="yes")
        {
            
            Console.Write("Enter number: ");
            string enteredNumber = Console.ReadLine();

            float enteredNumberFloat = float.Parse(enteredNumber);
            enteredNumberList.Add(enteredNumberFloat);
            if (enteredNumberFloat == 0)
            {
                keepTheLoop = "no"; 
            }
            
        }
        // foreach loop to iterate the list and make up the sum of the elements in the list
        foreach (float enteredNumber in enteredNumberList )
        {
            sum = sum + enteredNumber;
            listCount ++;

        }
        
        // storing the count in a list count variable
        listCount = enteredNumberList.Count;
        // computing the average
        average = sum/(listCount-1);
        // Displaying the sum and average of the entered numbers
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
    
    }
}