using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        GoalManager goalManager = new GoalManager();

        int choice;

        do
        {
            menu.ShowMainMenu();
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
                            SimpleGoal simpleGoal = new SimpleGoal();
                            simpleGoal.GatherGoalInfo();
                            goalManager.AddGoal(simpleGoal);
                            
                            break;
                        case 2:
                            Console.WriteLine("Goal 2");
                            break;

                        case 3:
                            Console.WriteLine("Goal 3");
                            break;

                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    };
                    
                    break;

                case 2:
                    goalManager.DisplayGoals();
                    break;

                case 3:
                    goalManager.SaveData();
                    break;

                case 4:
                    goalManager.LoadData();
                    break;

                case 5:
                    goalManager.RecordEvent();
                    break;

                case 6:
                    Console.WriteLine("Quit");
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (choice != 6);
    }
}
