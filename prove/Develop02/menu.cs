using System;

public class Menu
{
    public static void DisplayMenu()
    {
        Console.WriteLine("Please, select one of the following:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. load");
        Console.WriteLine("5. Statistics");
        Console.WriteLine("6. Quit");
        Console.WriteLine();
        Console.Write("What would you like to do? ");
    }

    public static int Choice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 6)
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            Console.Write("What would you like to do? ");
        }
        return choice;
    }
}