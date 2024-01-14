using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();

        int magicNumberInt = randomGenerator.Next(1,101);
        
        string starter = "on";

        int counter = 0;

        while(starter == "on")
        {
           Console.Write("What is your guess: ");

            string guess = Console.ReadLine();

            counter++;

            int guessInt = int.Parse(guess);
            if (magicNumberInt > guessInt)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumberInt < guessInt){
                Console.WriteLine("Lower");
            }
            else if (magicNumberInt == guessInt){
                Console.WriteLine("You guessed it!!");
                Console.WriteLine($"You made {counter} attempts before making the right guess...");
                starter = "off";
            }

        }

        


    }
}