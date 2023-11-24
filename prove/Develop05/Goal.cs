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
    private bool _isCompleted;

    public Goal(string goalName, string goalDescription, double amountPoints)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _amountPoints = amountPoints;
        _isCompleted = false;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetGoalDescription()
    {
        return _goalDescription;
    }

    public double GetAmountPoints()
    {
        return _amountPoints;
    }

    public void SetGoalName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _goalName = Console.ReadLine();
    }

    public void SetGoalDescription()
    {
        Console.WriteLine("What is a short description of it? ");
        _goalDescription = Console.ReadLine();
    }

    public void SetAmountPoints()
    {
        Console.WriteLine("What is the amount of point associated with this goal? ");
        _amountPoints = double.Parse(Console.ReadLine());
    }

    public virtual bool IsCompleted()
    {
        return _isCompleted;
    }

    public void Completed()
    {
        _isCompleted = true;
    }
}
