class Reception : Event
{
    private string RSVPEmail { get; }

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string rsvpEmail)
        : base(title, description, date, time, address, "Reception")
    {
        RSVPEmail = rsvpEmail;
    }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nRSVP Email: {RSVPEmail}";
    }
}