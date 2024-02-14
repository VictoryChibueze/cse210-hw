public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    

    public ListingActivity(int count,string name = "Listing", string description = "reflect on the good things in your life by having you list as many things as you can in a certain area.",int duration = 10):base(name,description,duration)
    {
        _count = count;
        _prompts = new List<string>();
    
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.Write("You may begin in:");
        ShowCountDown(4);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while(startTime < endTime)
        {
            Console.Write("> ");
            String userEntry = Console.ReadLine();
            _count++;
            
            startTime = DateTime.Now;
            

        }
        
        Console.WriteLine($"You have listed {_count} items!");
               
        Console.WriteLine("");
        DisplayEndingMessage();
        Console.Clear();

    }

    public void CountUserEntries()
    {
    }

    public void GetRandomPrompt()
    {
        string filePath = "Prompts.txt";
        if(File.Exists(filePath))
        {
            _prompts  = new List<string>(File.ReadAllLines(filePath));

            if(_prompts.Count > 0)
            {
                Random randomPrompt = new Random();
                int randomIndex = randomPrompt.Next(0,_prompts.Count);
            
                Console.WriteLine("");
                Console.WriteLine($"-- {_prompts[randomIndex]} --");



            }
        }
       

    }

    
}

