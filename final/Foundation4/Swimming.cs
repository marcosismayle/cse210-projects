public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / (length / 60)) * 60;
    }

    public override double GetPace()
    {
        return (length / 60) / GetDistance();
    }

    public new string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F2} min per km";
    }
}
