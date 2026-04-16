// Creativity: Hi, for show creativity I added scoring system and file saving/loading for persistence.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\n1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();

            if (choice == "1") manager.CreateGoal();
            else if (choice == "2") manager.DisplayGoals();
            else if (choice == "3") manager.RecordEvent();
            else if (choice == "4") manager.DisplayScore();
            else if (choice == "5") manager.Save("goals.txt");
            else if (choice == "6") manager.Load("goals.txt");
            else if (choice == "7") break;
        }
    }
}