class SimpleGoals : Goals
{
    // Atributes
    private bool _completed;

    // Constructors
    public SimpleGoals(string name, string description, int point) : base(name, description, point){
        _completed = false;
    }
    public SimpleGoals(string name, string description, int point, bool completed) : 
                        base(name, description, point){
        _completed = completed;
    }


    // Behaviours
    // Getters and Setters
    public bool GetCompleted(){
        return _completed;
    }
    
    // Display the Simple goals in its appropiate format
    public override void DisplayGoal(){
        char markCompleted = ' ';
        if (_completed == true){
            markCompleted = 'X';
        }
        Console.WriteLine($"[{markCompleted}] {GetName()} ({GetDescription()})");
    }

    // Transform goal attributes values to a list of strings
    public override List<string> GetStringParameters(){      
        List<string> oList = new List<string>();                // Create oList to contain all attributes values
        oList.Add("Simple :");
        oList.Add(GetName());
        oList.Add(GetDescription());
        oList.Add(GetPoint().ToString());                       // Transform integer types to string
        oList.Add(GetCompleted().ToString());
        return oList;
    }

    // Record goal completition by changing the _completed boolean value to true
    public override void GoalDone(){
        _completed = true;
        Console.Write("\nCONGRATULATIONS! You have completed this goal:");
        DisplayGoal();
    }

    // Not add Additional Points 
    public override int AdditionalPoints(){
        return 0;
    }
}
