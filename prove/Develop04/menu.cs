using System;

public class Menu
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity ");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity ");
        Console.WriteLine("4. Start Feeling activity ");
        Console.WriteLine("5. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
    }

    public static int Choice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            Console.Write("Select a choice from the menu: ");
        }
        return choice;
    }
}