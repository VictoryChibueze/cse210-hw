public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _address;
    private string _eventType;


    public Event(string title,string description,DateTime date,string address,string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _address = address;
        _eventType = eventType;
        


    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_date.ToShortTimeString()}\nAddress:{_address}";

    }

    public string FullDetails()
    {
        return GetStandardDetails();

    }
    public string ShortDescription()
    {
        return $"Event Type: {_eventType} \n Title: {_title} \n Date: {_date.ToShortDateString()}";
    }

}