public class PromptGenerator
{
   
    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        _prompts.Add("If I had one thing to do today,what could that be?");
        _prompts.Add("What is the best part of your day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("How did you improve the walk with the Lord today?");
        _prompts.Add("How  was the temple gathering today");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("How did I show love to people around me today");
        _prompts.Add("If I had one thing to do today,what could that be");


        Random random = new Random();

        int randomIndex = random.Next(0,_prompts.Count);
        string randomElememt = _prompts[randomIndex];

        return randomElememt;
    }
}