using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("BreathingActivity")
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ";
        _duration = 0;
    }

    public void Run()
    {
        DisplayStartingMessage(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds would you like for your session? ");

        if (int.TryParse(Console.ReadLine(), out int duration))
        {
            Console.Clear();
            Console.WriteLine("Get Ready... ");
            Console.WriteLine();
            Thread.Sleep(1000);
            DateTime endTime = DateTime.Now.AddSeconds(duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...  ");
                Console.Write("Now Breathe in: ");
                Countdown(4);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Breathe out... ");
                Console.Write($"Now Breathe out... ");
                Countdown(7);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        else{
            Console.WriteLine("Invalid input. Please enter a valid number. ");
        }    
        DisplayEndingMessage(duration);    
    }
}