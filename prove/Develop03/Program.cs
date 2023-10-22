class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture();
        Word wordManager = new Word(scripture.GetScripture());

        do
        {
            Console.Clear();

            Reference reference = new Reference();
            Console.Write(reference.GetReference());
            
            Console.WriteLine(wordManager.GetHiddenScripture());
            
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            string userInput = Console.ReadLine();

            if (string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
            
            wordManager.HideRandomWord();
        } while (wordManager.HasWordsRemaining());
    }
}
