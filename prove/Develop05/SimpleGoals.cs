/*
SimpleGoals
- CompletionPoints: int
+ RecordEvent(): void
*/

// SimpleGoal.cs

using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, double amountPoints)
        : base(goalName, goalDescription, amountPoints)
    {
    }

    public void GatherGoalInfo()
    {
        SetGoalName();
        SetGoalDescription();
        SetAmountPoints();
    }
}
