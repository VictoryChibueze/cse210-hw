public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description,int duration)
    {
        _name = name;
        _description  = description;
        _duration = duration;

    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine("");
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine("");
        Console.Write("How long, in second, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);

        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(3);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Welldone!");
        ShowSpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity");
        ShowSpinner(5);

    }

    public void ShowSpinner(int second)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(second);
        int i = 0;
        while(DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if(i>=animationString.Count)
            {
                i = 0;
            }


        }




    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0 ; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    
}