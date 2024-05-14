using System;
using System.Net.Quic;
// For the stretch challenge, I ask the user to input how many words to 
//hide each time Enter is pressed.
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Scripture Mastery:");
        Console.Write("Please enter how many words you would like to hide each time:");
        string userHide = Console.ReadLine();
        int wordsToHide;

        while (string.IsNullOrEmpty(userHide) || !int.TryParse(userHide, out wordsToHide))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write("Please enter how many words you would like to hide each time:");
            userHide = Console.ReadLine();
        }

        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        Console.Write(reference);
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

        
        
        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string quit = Console.ReadLine();
            scripture.HideRandomWords(wordsToHide);

            if (quit == "quit")
            {
                break;
            }
            
        } 
        
                //loop
            //display, hide, check if we need to quit
            // Use the functions in the Scripture class
    }
}

