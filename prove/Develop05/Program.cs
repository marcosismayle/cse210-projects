using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu(); // Create an instance of the Menu class

        int choice;

        do
        {
            menu.ShowMainMenu(); // Call the ShowMainMenu method on the menu instance
            choice = menu.GetChoice();

            switch (choice)
            {
                case 1:
                    GoalCreationMenu goalCreationMenu = new GoalCreationMenu();
                    int goalChoice;

                    goalCreationMenu.ShowGoalCreationMenu();
                    goalChoice = goalCreationMenu.GetChoice();

                    switch (goalChoice)
                    {
                        case 1:
                            SimpleGoal simpleGoal = new SimpleGoal("DefaultName", "DefaultDescription", 0);
                            simpleGoal.GatherGoalInfo();
                            
                            break;
                        case 2:
                            Console.WriteLine("Goal 2");
                            // Add logic for listing goals
                            break;

                        case 3:
                            Console.WriteLine("Goal 3");
                            // Add logic for saving goals
                            break;

                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    };
                    
                    break;

                case 2:
                    Console.WriteLine("Listing Goals");
                    // Add logic for listing goals
                    break;

                case 3:
                    Console.WriteLine("Saving Goals");
                    // Add logic for saving goals
                    break;

                case 4:
                    Console.WriteLine("Loading Goals");
                    // Add logic for loading goals
                    break;

                case 5:
                    Console.WriteLine("Recording Event");
                    // Add logic for recording an event
                    break;

                case 6:
                    Console.WriteLine("Quit");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (choice != 6); // Change the loop condition to match the available options
    }
}
