using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private const string FileName = "goals.txt";
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting the program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;

            }


        }
    }

    // DisplayPlayerInfo - Shows current score
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    // ListGoalNames - Lists all goals with their status
    public void ListGoalNames()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    // ListGoalDetails - Lists all goal types
    public void ListGoalDetails()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            string checkbox = _goals[i].IsComplete() ? "[X]" : "[ ]";
            Console.WriteLine($"{i + 1}. {checkbox} {_goals[i].GetDetailsString()}");
        }
    }

    // CreateGoal - Prompts user to create a new goal
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string choice = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        if (!int.TryParse(Console.ReadLine(), out int points) || points < 0)
        {
            Console.WriteLine("Invalid input for points. Please enter a non-negative integer.");
            return;
        }

        Goal newGoal = null;

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                if (!int.TryParse(Console.ReadLine(), out int target) || target <= 0)
                {
                    Console.WriteLine("Invalid input for target. Please enter a positive integer.");
                    return;
                }

                Console.Write("What is the bonus for accomplishing it that many times? ");
                if (!int.TryParse(Console.ReadLine(), out int bonus) || bonus < 0)
                {
                    Console.WriteLine("Invalid input for bonus. Please enter a non-negative integer.");
                    return;
                }

                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid choice. Goal not created.");
                return;
        }
        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully.");
        }
    }

    // RecordEvent - Records completion of a goal
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        if (int.TryParse(Console.ReadLine(), out int choice) &&
            choice > 0 && choice <= _goals.Count)

        {
            Goal selectedGoal = _goals[choice - 1];

            // Check if the goal is already complete (for SimpleGoal,  ChecklistGoal)
            if (selectedGoal is SimpleGoal simpleGoal && simpleGoal.IsComplete())
            {
                Console.WriteLine("This goal is already completed.");
                return;
            }

            selectedGoal.RecordEvent();
            int pointsEarned = selectedGoal.GetPoints();
            _score += pointsEarned;
            Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
            Console.WriteLine($"Your total score is now {_score} points.");



            if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                int bonus = checklistGoal.GetBonus();
                _score += bonus;
                Console.WriteLine($"Bonus! You have earned an additional {bonus} points for completing the checklist goal.");
                Console.WriteLine($"Your total score is now {_score} points.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }

    // SaveGoals - Saves goals to a file
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(_score);

                foreach (Goal goal in _goals)
                {
                    writer.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    // LoadGoals - Loads goals from a file
    public void LoadGoals()
    {
        Console.Write("What is the filename to load goals from? ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        try

        {
            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);

            if (lines.Length > 0)
            {
                if (int.TryParse(lines[0], out int savedScore))
                {
                    _score = savedScore;
                }

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split(", ");
                    string[] details = parts[0].Split(", ");
                    string name = details[0];
                    string description = details[1];
                    int points = int.Parse(details[2]);

                    Goal loadedGoal = null;

                    if (parts[1] == "True" || parts[1] == "False")
                    {
                        // SimpleGoal
                        bool isComplete = bool.Parse(parts[1]);
                        loadedGoal = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            loadedGoal.RecordEvent();
                        }
                    }
                    else if (parts[1] == "Eternal")
                    {
                        // EternalGoal
                        loadedGoal = new EternalGoal(name, description, points);
                    }
                    else if (parts.Length >= 4)
                    {
                        // ChecklistGoal
                        string[] progressParts = parts[1].Split('/');
                        int amountCompleted = int.Parse(progressParts[0]);
                        int target = int.Parse(progressParts[1]);
                        int bonus = int.Parse(parts[2]);

                        loadedGoal = new ChecklistGoal(name, description, points, target, bonus);
                        for (int j = 0; j < amountCompleted; j++)
                        {
                            loadedGoal.RecordEvent();
                        }
                    }

                    if (loadedGoal != null)
                    {
                        _goals.Add(loadedGoal);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading goals: {ex.Message}");
            return;
        }
    }

}