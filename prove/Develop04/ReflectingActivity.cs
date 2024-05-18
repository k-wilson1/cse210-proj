using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private Random _random;
    private int _currentIndex = 0;
    public ReflectingActivity() : base("Reflecting Activity")
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects on your life.";
        _duration = 50;
        _prompts = new List<string>
            {"Think of a time when you stood up for someone else.", 
            "Think of a time when you did something really difficult", 
            "Think of a time when you helped someone in need.", 
            "Think of a time when you did something truly selfless."
            };
        _questions = new List<string>
            {"Why was this experience meaningful to you?", 
            "Have you ever done anything like this before?", 
            "How did you get started?", 
            "How did you feel when it was complete?", 
            "How did you get started?", 
            "What made this time different than other times when you were not as successful?", 
            "What is your favorite thing about this experience?", 
            "What could you learn from this experience that applies to other situations?", 
            "What did you learn about yourself through this experience?", 
            "How can you keep this experience in mind in the future?"
            };
        _random = new Random();
    }
    public void Run()
    {
        DisplayStartingMessage(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            DisplayPrompt();
            ShowSpinner(1);
            DisplayQuestion(duration);
        }
        else{
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        DisplayEndingMessage(duration);
    }
    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        string question = _questions[_currentIndex];
        _currentIndex++;

        if (_currentIndex >= _questions.Count)
        {
            _currentIndex = 0;
        }
        return question;
    }
    public void DisplayPrompt()
    {
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"---{GetRandomPrompt()}--- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.WriteLine();
        Console.ReadLine();
    }
    public void DisplayQuestion(int duration)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < endTime)
        {
            Console.Clear();
            Console.Write(GetRandomQuestion());
            Console.WriteLine();
            ShowSpinner(4);
        }
    }
}