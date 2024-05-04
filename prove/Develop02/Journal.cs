using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string _date = parts[0];
            string _prompts = parts[1];
            string _entryText = parts[2];
         
            Entry entry = new Entry
            {
                _date = _date,
                _promptText = _prompts,
                _entryText = _entryText
            };
        _entries.Add(entry);
        }
    }

    public void SaveToFile(string fileName)
    {      
        using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
    }
    public int CountEntries()
    {
        return _entries.Count;
    }
    
}

