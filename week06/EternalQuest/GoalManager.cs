using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;
    private string _fileName = "goals.txt";
    private int _userInput = 0;
    private int _index = 0;

    public void Start()
    {
        while (_userInput != 6)
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            Console.WriteLine("");

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create a New Goal");
            Console.WriteLine("  2. List goals");
            Console.WriteLine("  3. Load goals");
            Console.WriteLine("  4. Save goals");
            Console.WriteLine("  5. Record event");
            Console.WriteLine("  6. Exit");
            Console.Write("Select a choice from the menu: ");

            _userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.Clear();

            if (_userInput == 1)
            {
                CreateGoal();
            }
            else if (_userInput == 2)
            {
                ListGoalNames();
            }
            else if (_userInput == 3)
            {
                LoadGoals();
            }
            else if (_userInput == 4)
            {
                SaveGoals();
            }
            else if (_userInput == 5)
            {
                RecordEvent();
            }
            else if (_userInput == 6)
            {
                Console.WriteLine("Good luck with your goals!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_totalPoints} points.");
    }

    public void ListGoalNames()
    {
        _index = 0;
        Console.WriteLine("Your goals are: ");
        foreach (Goal goal in _goals)
        {
            _index++;
            Console.WriteLine($"{_index}. {goal.GetStringRepresentation()}");
        }
    }

    public void ListGoalShort()
    {
        _index = 0;
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in _goals)
        {
            _index++;
            Console.WriteLine($"{_index}. {goal.GetGoalName()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (goalType == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (goalType == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
    }

    public void RecordEvent()
    {
        ListGoalShort();
        Console.Write("Which goal did you accomplish? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        _totalPoints = _goals[goalIndex].RecordEvent() + _totalPoints;
        Console.WriteLine($"You now have {_totalPoints} points.");
    }

    public void SaveGoals()
    {
        Console.WriteLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine($"TotalPoints|{_totalPoints}");

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GenFileFormat()}");
            }
        }
    }

    public void LoadGoals()
    {
        _goals.Clear();
        Console.WriteLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] goal = line.Split('|');
            if (goal[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(goal[1], goal[2], int.Parse(goal[3])));
            }
            else if (goal[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(goal[1], goal[2], int.Parse(goal[3])));
            }
            else if (goal[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(goal[1], goal[2], int.Parse(goal[3]), int.Parse(goal[4]), int.Parse(goal[5]), int.Parse(goal[6])));
            }
            else if (goal[0] == "TotalPoints")
            {
                _totalPoints = int.Parse(goal[1]);
            }
        }
    }
}