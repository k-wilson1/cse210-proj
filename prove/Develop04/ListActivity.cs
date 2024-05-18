using System;
using System.Collections.Generic;
using System.Threading;

public class ListActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random;

    public ListActivity() : base("Listing Activity")
    {
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts =  new List<string>
            {"Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"
            };
        _random = new Random();
    }
    public void Run()
    {
        DisplayStartingMessage(_description);
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();
        if (int.TryParse(durationInput, out int duration))
        {
            string prompt = GetRandomPrompt();
            Console.Clear();
            Console.WriteLine("List as many responses you can to the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"---{prompt}---");
            Console.WriteLine();
            Console.Write("You may begin in: ");
            Countdown(5);
            Console.WriteLine();

            List<string> userList = GetListFromUser(duration);
            Console.WriteLine($"You listed {userList.Count} items.");
            // Can do a stretch here, save the list to a txt

            DisplayEndingMessage(duration);
        }
    }

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            string input = Console.ReadLine();
            userList.Add(input);
        } 
    
        return userList;
    }
}