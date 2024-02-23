public class Receptions:Event
{
    private string _rsvpEmail;

    public Receptions(string title,string description,DateTime date,string address,string eventType,string rsvpEmail):base(title,description,date,address,eventType)
    {
        _rsvpEmail = rsvpEmail;
    }
}