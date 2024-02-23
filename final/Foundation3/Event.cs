public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _address;


    public Event(string title,string description,DateTime date,string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
        
        

    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\n Description: {_description}\n Date: {_date.ToShortDateString()}\n Time: {_date.ToShortTimeString()}\nAddress:{_address}";

    }

    public string FullDetails()
    {
        return GetStandardDetails();

    }
    public string ShortDescription()
    {
        return $"Event Type: Generic Event \n Title: {_title} \n Date: {_date.ToShortDateString()}";
    }

}