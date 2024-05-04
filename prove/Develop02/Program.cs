using System;
using System.IO;
using System.Collections.Generic;

// For my creativity I added a count feature that will count how many 
//entries you saved and when you load, how many entries are in the txt file.

int choice = 0;
Journal journal = new Journal();

Console.WriteLine("Welcome to the Journal Program!");

while (choice != 5)
{
    Console.WriteLine("Please select one of the following choice:");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");
    Console.Write("What would you like to do? ");
    choice = int.Parse(Console.ReadLine());

    if (choice == 1)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator promptGenerator = new PromptGenerator();
        string promptText = promptGenerator.GeneratePrompt();

        Console.WriteLine(promptText);
        Console.Write(">");
        string entryText = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = dateText,
            _promptText = promptText,
            _entryText = entryText
        };
        journal.AddEntry(newEntry);
    }
    else if (choice == 2)
    {
        journal.DisplayAll();
    }
    else if (choice == 3)
    {
        Console.WriteLine("What is the file name? ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);

        int count = journal.CountEntries();
        Console.WriteLine($"You have {count} entries in your journal. ");
    }


    else if (choice == 4)
    {
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        journal.SaveToFile(fileName);

        int count = journal.CountEntries();

        Console.WriteLine($"You added {count} entries in your journal. ");
    }
}
