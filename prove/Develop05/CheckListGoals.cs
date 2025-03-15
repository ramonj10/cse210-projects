class CheckListGoals : Goals
{
    // Atributes
    private int _timesToComplete;
    private int _timesDone;
    private int _extraPoints;

    // Constructors
    public CheckListGoals(string name, string description, int point, int timeToComplete, int extraPoints) 
                        : base(name, description, point){
        _timesToComplete = timeToComplete;
        _timesDone = 0;
        _extraPoints = extraPoints;
    }
    public CheckListGoals(string name, string description, int point, int timeToComplete, int timesDone, int extraPoints) 
                        : base(name, description, point){
        _timesToComplete = timeToComplete;
        _timesDone = timesDone;
        _extraPoints = extraPoints;
    }

    // Behaviours
    // Getters and Setters
    public int GetTimesToComplete(){
        return _timesToComplete;
    }
    public int GetTimesDone(){
        return _timesDone;
    }
    public int GetExtraPoints(){
        return _extraPoints;
    }
    public void SetTimesToComplete(int timesToComplete){
        _timesToComplete = timesToComplete;
    }
    public void SetExtraPoints(int extraPoints){
        _extraPoints = extraPoints;
    }

    // Display the CheckList goals in its appropiate format
    public override void DisplayGoal(){
        char markCompleted = ' ';
        if (_timesDone >= _timesToComplete){
            markCompleted = 'X';
        }
        Console.WriteLine($"[{markCompleted}] {GetName()} ({GetDescription()})" + 
                    $" -- Currently completed: {_timesDone}/{_timesToComplete}");
    }
    
    // Transform goal attributes values into a list of strings
    public override List<string> GetStringParameters(){      
        List<string> oList = new List<string>();                // Create oList to contain all attributes values
        oList.Add("Checklist :");
        oList.Add(GetName());
        oList.Add(GetDescription());
        oList.Add(GetPoint().ToString());                       // Transform integer types to string
        oList.Add(GetTimesToComplete().ToString());
        oList.Add(GetTimesDone().ToString());
        oList.Add(GetExtraPoints().ToString());
        return oList;
    }

    // Record goal completition by increasing the value of timesDone
    public override void GoalDone(){
        _timesDone += 1;
        if (_timesDone < _timesToComplete){
            int remaining = _timesToComplete - _timesDone;
            Console.WriteLine($"\nWELL DONE! You have done {_timesDone} time this goal. You need {remaining} more times to complete this goal:");
            DisplayGoal();
        }
        else {
            Console.WriteLine("\nCONGRATUALTION! You have completed this goal:");
            DisplayGoal();
        }
    }

    // Add the Additional Points whenever the Times to complete is achieved.
    public override int AdditionalPoints(){
        if (_timesDone == _timesToComplete){
            return _extraPoints;
        }
        else {
            return 0;
        }
    }
}