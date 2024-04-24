using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter a number. Enter 0 when finished: ");
            string userNumber = Console.ReadLine();
            userInput = int.Parse(userNumber);

            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max number is: {max}");
    }
}