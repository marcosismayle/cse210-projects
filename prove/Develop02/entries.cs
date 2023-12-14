using System;
using System.Collections.Generic;
using System.IO;

public class JournalEntries
{
    private List<string> userInputs = new List<string>();

    public void newEntry(string entry)
    {
        userInputs.Add(entry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("New entries:");
        foreach (string entry in userInputs)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string entry in userInputs)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    //this part was updated to fix how the program loads external files
    public static List<string> ReadFromFile(string filename)
    {
        Console.WriteLine($"Reading list from file {filename}...");

        List<string> entries = new List<string>();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                entries.Add(line);
            }

            Console.WriteLine("Entries loaded successfully.");
        }
        else
        {
            Console.WriteLine($"File {filename} not found. No entries loaded.");
        }

        return entries;
    }


    public int GetNumberOfEntries()
    {
        return userInputs.Count;
    }

    public double GetCharacterAverageByEntry()
    {
        if (userInputs.Count == 0)
        {
            return 0.0;
        }

        int totalCharacters = userInputs.Sum(entry => entry.Length);
        return (double)totalCharacters / userInputs.Count;
    } 
}