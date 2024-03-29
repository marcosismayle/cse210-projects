using System;
//exceed requirement
//I used Console.Clear() to clear the console and added one more option to show statistics like, how many entries and the average of characters by entry.

class Program
{
    private static JournalEntries JournalEntries = new JournalEntries();
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Menu.DisplayMenu();
            choice = Menu.Choice();

            switch(choice)
            {
                case 1:
                    Console.Clear();
                    string randomPrompt = PromptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);
                    string userInput = Console.ReadLine();
                    string date = DateTime.Now.ToString("MM/dd/yyyy");
                    string formatedEntry = $"Date: {date} - Prompt: {randomPrompt}\n{userInput}";
                    JournalEntries.newEntry(formatedEntry);
                    Console.Clear();
                    
                    break;
                case 2:
                    Console.Clear();
                    JournalEntries.DisplayEntries();
                    Console.ReadLine();
                    Console.Clear();
                    break;
                
                case 3:
                    Console.Clear();                    
                    JournalEntries.SaveToFile("journal.txt");
                    Console.WriteLine("New entries has been saved!");
                    break;
            
                case 4:
                    Console.Clear();
                    List<string> loadedEntries = JournalEntries.ReadFromFile("journal.txt");
                    foreach (string entry in loadedEntries)
                    {
                        Console.WriteLine(entry);
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;


                case 5:
                    Console.Clear();
                    int numberOfEntries = JournalEntries.GetNumberOfEntries();
                    double characterAverage = JournalEntries.GetCharacterAverageByEntry();
                    Console.WriteLine($"You have a total of {numberOfEntries} entries, with an average of {characterAverage} characters by entry.");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            
                case 6:
                    Console.Clear();
                    Console.WriteLine("Quit");
                    break;

                default:
                    Console.Clear();                
                    Console.WriteLine("Invalid option!");
                    break;
            }
        } while (choice != 6);
    }
}