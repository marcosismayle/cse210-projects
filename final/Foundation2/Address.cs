class Address
{
    private string StreetAddress { get; }
    private string City { get; }
    private string StateProvince { get; }
    private string Country { get; }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public bool InUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetAddressString()
    {
        return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
    }
}
