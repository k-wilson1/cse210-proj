using System;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastname}, {fname} {lastname}. ");
    }
}