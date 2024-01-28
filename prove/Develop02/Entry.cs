public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public string _mood;

    

      public void Display()
    {
       
        Console.WriteLine(_promptText);
        Console.Write("> ");
        _entryText = Console.ReadLine();
        DateTime date = DateTime.Now;
        _date = date.ToShortDateString();
    }


    public void Mood()
    {

         // Prompting the user for his mood
        Console.WriteLine("What's your mood today (happy || sad || stressed)?");
        string _mood = Console.ReadLine();
        

        if (_mood.ToLower() == "sad")
        {
             Console.WriteLine("Oh sorry, you are feeling..Do well to pray ,things will get better");

        } else if (_mood.ToLower() == "happy")
        {
            Console.WriteLine("Hurray!!, keep up the spirit of happiness");
        }else if(_mood.ToLower() == "stressed")
        {
            Console.WriteLine("Try and get some rest and also get a nice meal");
        }
        else{
            Console.WriteLine("Invalid entry! ..Not able to get how you feel today.");
        }
    }

}


