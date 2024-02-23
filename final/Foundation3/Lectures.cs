public class Lectures:Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title,string description,DateTime date,string address,string eventType,string speaker,int capacity):base(title,description,date,address,eventType)
    {
        _speaker = speaker;
        _capacity = capacity;
    }


}