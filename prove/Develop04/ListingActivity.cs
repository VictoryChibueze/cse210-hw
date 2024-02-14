public class ListingActivity:Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(int count,string name, string description,int duration):base(name,description,duration)
    {
        _count = count;
        _prompts = new List<string>();
    }

    public void Run()
    {

    }

    public void GetRandomPrompt()
    {

    }

    
}