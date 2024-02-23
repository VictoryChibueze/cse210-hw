public class Receptions:Event
{
    private string _rsvpEmail;

    public Receptions(string title,string description,DateTime date,string address,string rsvpEmail):base(title,description,date,address)
    {
        _rsvpEmail = rsvpEmail;
    }
}