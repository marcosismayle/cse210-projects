/*
SimpleGoals
- CompletionPoints: int
+ RecordEvent(): void
*/

// SimpleGoal.cs

using System;

public class SimpleGoal : Goal
{
    public SimpleGoal() : base("", "", 0)
    {
    }

    public void GatherGoalInfo()
    {
        SetGoalName();
        SetGoalDescription();
        SetAmountPoints();
    }
}
