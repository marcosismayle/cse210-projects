public class PromptGenerator
{
    public static List<string> PromptsList = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most unexpected moment or encounter that happened today?",
        "How did I make a positive impact on someone's day today?",
        "What accomplishment or achievement am I most proud of from today?",
        "Did I learn something new today, and if so, what was it?",
        "What was the most challenging decision I had to make today, and how did I handle it?"
    };

    private static Random random = new Random();

    public static string GetRandomPrompt()
    {
        int randomIndex = random.Next(PromptsList.Count);
        return PromptsList[randomIndex];
    }
}