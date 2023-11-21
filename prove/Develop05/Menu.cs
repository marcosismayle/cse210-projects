/* Menu
+ ShowMainMenu(): void
+ ShowGoalCreationMenu(): void
+ ShowRecordEventMenu(): void
*/

using System;

public class Menu
{
    public virtual void ShowMainMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
    }

    public virtual int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
            Console.Write("Select a choice from the menu: ");
        }
        return choice;
    }
}

