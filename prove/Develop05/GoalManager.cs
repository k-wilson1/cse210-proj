using System;
using System.ComponentModel;
using System.Runtime;
using System.Threading.Channels;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

public class GoalManager
{
    private int _score = 0;
    private List<Goal> goals;

    public GoalManager()
    {
        goals = new List<Goal>();
    }
    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            DisplayPlayerInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();
                SaveGoals(fileName);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename for the goals? ");
                string fileName = Console.ReadLine();
                LoadGoals(fileName);
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else
            {
                break;
            }
        }
        
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < goals.Count; i++)    
                {
                    Console.WriteLine($"{i+1}. {goals[i].GetDetailsString()}");
                }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i=0; i < goals.Count; i++)
            {
                Console.WriteLine(); 
                Goal goal = goals[i]; 
                string complete = goal.IsComplete() ? "[X]" : "[ ]"; 
                Console.WriteLine($"{i+1}. {complete} {goal.GetDetailsString()}");
            }
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal ");
        Console.WriteLine("  2. Eternal Goal ");
        Console.WriteLine("  3. Checklist Goal ");
        Console.Write("Which type of goal would you like to create? ");
        string goaltype = Console.ReadLine();
        Goal newGoal = null;

        Console.Write("What is the name of your goal? ");
        string shortName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        if (goaltype == "1")
        {
            newGoal = new SimpleGoal(shortName, description, points);
        }
            
        else if (goaltype == "2")
        {
            newGoal = new EternalGoal(shortName, description, points);
        }
        else if (goaltype == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(shortName, description, points, target, bonus);
        }
        goals.Add(newGoal);            
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int accomplished = int.Parse(Console.ReadLine());

        Goal goal = goals[accomplished - 1];
        goal.RecordEvent();
        _score += goal.GetPoints();  
        Console.Write($"You Earned {goal.GetPoints()}");

    }
    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in goals)
            {
                outputFile.WriteLine($"{goal.GetType()}|{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        int score = int.Parse(lines[0]);
        _score = score;

        for(int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string [] parts = line.Split("|");
            string goaltype = parts[0];
            string _shortName = parts[1];
            string _description = parts[2];
            int _points = int.Parse(parts[3]);
            bool IsComplete = bool.Parse(parts[4]);

            Goal goal = null;

            if (goaltype == "SimpleGoal")
            {
                goal = new SimpleGoal(_shortName, _description, _points);
            }
            else if (goaltype == "EternalGoal")
            {
                goal = new EternalGoal(_shortName, _description, _points);

            }
            else if(goaltype == "ChecklistGoal")
            {
                int _bonus = int.Parse(parts[5]);
                int _target = int.Parse(parts[6]);
                int amountCompleted = int.Parse(parts[7]);
                goal = new ChecklistGoal(_shortName, _description, _points, _target, _bonus);

            }
            if (goal != null)
            {
                goals.Add(goal);
            }
        }
    }
}