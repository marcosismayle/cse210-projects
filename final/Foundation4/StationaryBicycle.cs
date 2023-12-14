public class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int length, double speed) : base(date, length)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public new string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {speed:F1} mph";
    }
}
