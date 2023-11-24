/*
GoalManager
- goals: List<Goal>
+ AddGoal(newGoal: Goal): void
+ RecordEvent(goalName: string): void
+ DisplayGoals(): void
+ SaveData(): void
+ LoadData(): void
*/

using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> goals;

    public GoalManager()
    {
        goals = new List<Goal>();
    }

    public void AddGoal(Goal newGoal)
    {
        goals.Add(newGoal);
    }

    public Goal GetGoalByIndex(int index)
    {
        if (index >= 0 && index < goals.Count)
        {
            return goals[index];
        }
        else
        {
            Console.WriteLine("Invalid index. Returning null.");
            return null;
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.Write("Which goal did you accomplish? Enter the corresponding number: ");

        if (int.TryParse(Console.ReadLine(), out int selectedGoalIndex) && selectedGoalIndex >= 1 && selectedGoalIndex <= goals.Count)
        {
            Goal selectedGoal = goals[selectedGoalIndex - 1];
            this.GetGoalByIndex(selectedGoalIndex - 1).Completed();

            RecordEvent(selectedGoal);

            Console.WriteLine($"Congratulations! You have earned {selectedGoal.GetAmountPoints()} points!");
            Console.WriteLine($"Now you have {selectedGoal.GetAmountPoints()} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal selection. Please enter a valid number.");
        }
    }

    private void RecordEvent(Goal selectedGoal)
    {
    }

    public void DisplayGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            Console.WriteLine("List of Goals:");
            for (int i = 0; i < goals.Count; i++)
            {
                string checkBox = goals[i].IsCompleted() ? "[X]" : "[ ]";
                Console.WriteLine($"{i+1}. {checkBox} {goals[i].GetGoalName()} ({goals[i].GetGoalDescription()})");
            }
        }
    }

    public void SaveData()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (Goal goal in goals)
                {
                    string line = $"{goal.GetGoalName()}|{goal.GetGoalDescription()}|{goal.GetAmountPoints()}|{goal.IsCompleted()}";
                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Goals saved to goals.txt");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    public void LoadData()
    {
        try
        {
            goals.Clear();

            using (StreamReader reader = new StreamReader("goals.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('|');

                    if (parts.Length == 4)
                    {
                        string goalName = parts[0];
                        string goalDescription = parts[1];
                        double amountPoints = double.Parse(parts[2]);
                        bool isCompleted = bool.Parse(parts[3]);

                        Goal goal = new Goal(goalName, goalDescription, amountPoints);

                        goals.Add(goal);
                    }
                }
            }

            Console.WriteLine("Goals loaded from goals.txt");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("No saved goals found. Starting with an empty list.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }
}