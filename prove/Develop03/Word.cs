using System;
using System.Linq;
using System.Collections.Generic;

public class Word
{
    private List<string> _words;
    private List<string> _hiddenWords;
    private List<int> _hiddenWordIndices;
    private Random _random;

    public Word(string scripture)
    {
        _words = scripture.Split(new[] { ' ', '\t', '\r', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        _hiddenWords = _words.ToList();
        _hiddenWordIndices = new List<int>();
        _random = new Random();
    }

    public bool HasWordsRemaining()
    {
        return _hiddenWords.Any(hiddenWord => !string.IsNullOrWhiteSpace(hiddenWord));
    }

    public string GetHiddenScripture()
    {
        return string.Join(" ", _hiddenWords);
    }

    public void HideRandomWord()
    {
        if (HasWordsRemaining()) //For stretch challenge just the non-hidden words is hidden.
        {
            int randomIndex;
            do
            {
                randomIndex = _random.Next(_words.Count);
            } while (_hiddenWordIndices.Contains(randomIndex) || string.IsNullOrWhiteSpace(_hiddenWords[randomIndex]));

            string hiddenWord = new string('_', _words[randomIndex].Length);
            _hiddenWords[randomIndex] = hiddenWord;
            _hiddenWordIndices.Add(randomIndex);
        }
    }
}
