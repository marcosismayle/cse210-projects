class Event
{
    private string Title { get; }
    private string Description { get; }
    private DateTime Date { get; }
    private TimeSpan Time { get; }
    private Address Address { get; }
    protected string EventType { get; }

    public Event(string title, string description, DateTime date, TimeSpan time, Address address, string eventType)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
        EventType = eventType;
    }

    public string GetStandardDetails()
    {
        return $"Event Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address.GetAddressString()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails() + $"\nEvent Type: {EventType}";
    }

    public string GetShortDescription()
    {
        return $"Event Type: {EventType}\nEvent Title: {Title}\nDate: {Date.ToShortDateString()}";
    }
}