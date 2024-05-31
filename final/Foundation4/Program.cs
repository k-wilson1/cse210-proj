using System;

class Program
{
    static void Main(string[] args)
    {
        Running running= new Running(13, 1.2);
        Console.WriteLine(running.GetSummary());

        Cycling cycling= new Cycling(30, 10, 5);
        Console.WriteLine(cycling.GetSummary());

        Swimming swimming= new Swimming(30, 30);
        Console.WriteLine(swimming.GetSummary());
    }
}