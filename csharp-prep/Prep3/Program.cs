using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        Console.Write("What is your guess? ");
        string gessInput = Console.ReadLine();

        int gess = int.Parse(gessInput);

        while (gess != number)
        {

            if (gess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (gess > number)
            {
                Console.WriteLine("Smaller");
            }

            Console.Write("What is your guess? ");
            gessInput = Console.ReadLine();

            gess = int.Parse(gessInput);
            
        }
        if (gess == number)
        {
            Console.WriteLine("You guessed it!");
        }
                
    }
}