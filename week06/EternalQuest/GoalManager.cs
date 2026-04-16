using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayGoals()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetStatus()} {goal.GetName()}");
            i++;
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (choice == "3")
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();
        _score += earned;

        Console.WriteLine($"You earned {earned} points!");
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal")
            {
                SimpleGoal g = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                _goals.Add(g);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            }
        }
    }
}