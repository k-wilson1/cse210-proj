using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        // Split up the words in text and store each as a word object in the list _words
        // Split and then loop through each word
        // String.Split then create a word object and put into _words
        _reference = reference;
        _words = new List<Word>();
        
        string[] words = text.Split(" ");

        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
        
    }

    public void HideRandomWords(int numberToHide)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }        
        Random random = new Random();
        for (int i=0; i < numberToHide; i++)
        {
            int index = random.Next(0, visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        //Reference, All the words
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            return false;
        }
        return true;
    }
}