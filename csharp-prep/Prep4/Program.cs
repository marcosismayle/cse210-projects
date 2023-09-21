using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        int numberInput = int.Parse(input);

        List<int> numbers = new List<int>();

        while (numberInput != 0)
        {
            numbers.Add(numberInput);

            Console.Write("Enter number: ");
            input = Console.ReadLine();

            numberInput = int.Parse(input);
        }

        float sum = 0;
        float average = 0;
        float largest = 0;

        foreach (int number in numbers)
        {
            sum += number;
            average = sum / numbers.Count;
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}