/*
Goal
- Name: string
- Points: int  
+ RecordEvent(): void
+ DisplayProgress(): void
*/

using System;

public class Goal
{
    private string _goalName;
    private string _goalDescription;
    private double _amountPoints;

    public Goal(string goalName, string goalDescription, double amountPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _amountPoints = amountPoints;
    }

    public string SetGoalName()
    {
        Console.WriteLine("What is the name of your goal? ");
        return Console.ReadLine();
    }

    public string SetGoalDescription()
    {
        Console.WriteLine("What is a short description of it? ");
        return Console.ReadLine();
    }

    public double SetAmountPoints()
    {
        Console.WriteLine("What is the amount of point associated with this goal? ");
        return double.Parse(Console.ReadLine());
    }
}
