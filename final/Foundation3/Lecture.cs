class Lecture : Event
{
    private string Speaker { get; }
    private int Capacity { get; }

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address, "Lecture")
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity} attendees";
    }
}