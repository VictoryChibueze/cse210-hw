public class PromptGenerator
{
   
    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>();
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("What is the best part of your day");
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("If I had one thing to do today,what could that be");
        _prompts.Add("If I had one thing to do today,what could that be");


        Random random = new Random();

        int randomIndex = random.Next(0,_prompts.Count);
        string randomElememt = _prompts[randomIndex];

        return randomElememt;
    }
}