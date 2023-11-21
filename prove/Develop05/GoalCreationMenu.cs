using System;

public class ShowGoalCreationMenu : Menu
{
    public override void ShowGoalCreationMenu()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();
        Console.Write("Which type of goal do you like to create? ");
    }

    public override int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
            Console.Write("Select a choice from the menu: ");
        }
        return choice;
    }
}