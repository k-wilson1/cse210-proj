using System;


public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name)
    {
        _name = name;
    }
    public void DisplayStartingMessage(string description)
    {
        _description = description;
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage(int duration)
    {
        _duration = duration;
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} activity for {_duration} seconds");
        ShowSpinner(3);
    }
    protected void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>
        {
            "-", "--", "---", "----", "---", "--", "-", "--", "---", "----", "---", "--", "-"
        };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b\b\b\b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
        Console.Write(new string(' ', animationStrings[animationStrings.Count - 1].Length));

    }
    protected void Countdown(int seconds)
    {
        
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}