public class ReflectingActivity:Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    // constructor

    public ReflectingActivity(string name = "Reflecting", string description = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life",int duration = 0):base(name,description,duration)
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }

    public void Run()
    {
        DisplayStartingMessage();

        // Console.WriteLine("Get ready...");
        // ShowSpinner(5);
        DisplayPrompt();
        Console.WriteLine("");
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        Console.Write("When you have something in mind, press enter to continue");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.WriteLine("");

        Console.Write("You may begin in: ");
        ShowCountDown(4);
        Console.WriteLine("");

       
        
        if(keyInfo.Key == ConsoleKey.Enter)
        {
            while(startTime < endTime)
            {
                DisplayQuestion();

                startTime = DateTime.Now;

            }

        }

        Console.WriteLine("");
        DisplayEndingMessage();
        
        Console.Clear();
        
        
      

    }

    public string GetRandomPrompt()
    {
        string filePath = "ReflectPrompt.txt";
        string finalPromptReturned = "";
        if(File.Exists(filePath))
        {
            _prompts = new List<string>(File.ReadAllLines(filePath));

            if(_prompts.Count > 0)
            {
                Random randomPrompt = new Random();
                int randomIndex1 = randomPrompt.Next(0,_prompts.Count);

                string prompt = _prompts[randomIndex1];

                finalPromptReturned = prompt;            

            }

         

        }
        return finalPromptReturned;



    }

    public string GetRandomQuestion()
    {
        string filePath = "ReflectQuestions.txt";
        string finalQuestionReturned = "";

        if(File.Exists(filePath))
        {
            _questions = new List<string>(File.ReadAllLines(filePath));

            if(_questions.Count > 0)
            {
                Random randomPrompt = new Random();
                int randomIndex2 = randomPrompt.Next(0,_questions.Count);

                string questions = _questions[randomIndex2];

                finalQuestionReturned = questions;            

            }

        }
        return finalQuestionReturned;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        string promptPrinter = GetRandomPrompt();
        Console.WriteLine($"--- {promptPrinter} ---");
        
    }

    public void DisplayQuestion()
    {
        string questionPrinter = GetRandomQuestion();
        Console.Write($"> {questionPrinter} ");
        ShowSpinner(10);
        Console.WriteLine("");

    }
}