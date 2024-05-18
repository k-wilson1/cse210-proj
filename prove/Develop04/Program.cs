using System;
using System.Xml.Serialization;
// By Katrina Wilson
// Week 4 Mindfullness Activity
// Stretch requirements: Spinner animation changed
// and I have it going through the list of questions in the 
// reflecting activity before starting over. 
class Program
{
    static void Main(string[] args)
    {
        ListActivity listActivity = new ListActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        BreathingActivity breathingActivity = new BreathingActivity();
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity ");
            Console.WriteLine("2. Start reflecting activity ");
            Console.WriteLine("3. Start listing activity ");
            Console.WriteLine("4. Quit ");
            Console.Write("Select a choice from the menu:  ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                breathingActivity.Run();
            }
            else if (choice == "2")
            {
                reflectingActivity.Run();
            }
            else if (choice == "3")
            {
                listActivity.Run();
            }
        }
    }    
}