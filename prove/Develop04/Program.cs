using System;
// To exceeds requirements it was added another actvity to the program.
class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();
            Menu.DisplayMenu();
            choice = Menu.Choice();

            switch(choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    breathingActivity.PromptBreathing();
                    breathingActivity.End();

                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Start();
                    reflectingActivity.PromptReflecting();
                    reflectingActivity.End();
                    break;
                
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    listingActivity.PromptListing();
                    listingActivity.End();
                    break;
                
                case 4:
                    FeelingActivity FeelingActivity = new FeelingActivity();
                    FeelingActivity.Start();
                    FeelingActivity.PromptFeeling();
                    FeelingActivity.End();
                    break;

                case 5:
                    Console.WriteLine("Quit");
                    break;

                default:          
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (choice != 5);
    }
}