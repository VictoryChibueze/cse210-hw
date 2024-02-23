using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures(
            "Inspirational Talk",
            "An uplifting speech to motivate and inspire",
            new DateTime(2024, 3, 15, 18, 30, 0),
            "123 Main St",
            "Lectures",
            "John Doe",
            100
        );

        Receptions reception = new Receptions(
            "Networking Mixer",
            "A social gathering for networking and connections",
            new DateTime(2024, 3, 20, 19, 0, 0),
            "456 Oak St",
            "Reception", 
            "Liennetworks@gmail.com" 
        );

        OutdoorGathering outdoorGathering = new OutdoorGathering(
            "Community Picnic",
            "A fun picnic for the local community",
            new DateTime(2024, 4, 5, 12, 0, 0),
            "City Park",
            "Outgathering"
        );
        DisplayEventMarketing(lecture);
        DisplayEventMarketing(reception);
        DisplayEventMarketing(outdoorGathering);


        
    }

    static void DisplayEventMarketing(Event eventInstance)
    {
        Console.WriteLine("Standard Details:");
        Console.WriteLine(eventInstance.GetStandardDetails());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(eventInstance.FullDetails());

        Console.WriteLine("\nShort Description:");
        Console.WriteLine(eventInstance.ShortDescription());

        Console.WriteLine("\n--------------------------------\n");
    }
}