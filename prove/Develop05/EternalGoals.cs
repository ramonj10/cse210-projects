class EternalGoals : Goals
{
    // Atributes
    private int _times;
    private int _timesToLevelUp;
    private int _levelPoints;

    // Constructors
    public EternalGoals(string name, string description, int point, int timesToLevelup, int levelPoints) 
                        : base(name, description, point){
        _times = 0;
        _timesToLevelUp = timesToLevelup;
        _levelPoints = levelPoints;
    }
    public EternalGoals(string name, string description, int point, int timesToLevelup, int levelPoints, int times) 
                        : base(name, description, point){
        _times = times;
        _timesToLevelUp = timesToLevelup;
        _levelPoints = levelPoints;
    }
    
    // Behaviours
    // Setters and Getters
    public int GetTimes(){
        return _times;
    }
    public int GetTimesToLevelUp(){
        return _timesToLevelUp;
    }
    public int GetLevelPoints(){
        return _levelPoints;
    }
    public void SetTimesToLevelUp(int timesToLevelUp){
        _timesToLevelUp = timesToLevelUp;
    }
    public void SetLevelPoints(int levelPoints){
        _levelPoints = levelPoints;
    }
    
    // Display the Eternal goals in its appropiate format
    public override void DisplayGoal(){
        Console.WriteLine($"[ ] {GetName()} ({GetDescription()}) \n\t==> " + 
                                 $"You have done it {_times} times so far.");
    }
    
    // Transform goal attributes values into a list of strings
    public override List<string> GetStringParameters(){      
        List<string> oList = new List<string>();                // Create oList to contain all attributes values
        oList.Add("Eternal :");
        oList.Add(GetName());
        oList.Add(GetDescription());
        oList.Add(GetPoint().ToString());                       // Transform integer types to string
        oList.Add(GetTimesToLevelUp().ToString());
        oList.Add(GetLevelPoints().ToString());
        oList.Add(GetTimes().ToString());
        return oList;
    }

    // Record goal completition by increasing the value of _times
    public override void GoalDone(){
        _times += 1;
        int level = _times / _timesToLevelUp;
        int toIncreaseLevel = _timesToLevelUp - _times % _timesToLevelUp;
        if (_times < _timesToLevelUp){
            Console.WriteLine($"\nWELL DONE! You are in LEVEL {level}. You only need {toIncreaseLevel} more times to jump to the next LEVEL with this goal:");
            DisplayGoal();
        }
        else {
            if (_times % _timesToLevelUp == 0){
                Console.WriteLine($"\nCONGRATULATIONS! You are in LEVEL {level}.");
                DisplayGoal();
            }

            else {
                Console.WriteLine($"\nYou are in LEVEL {level}. You just need to completed {toIncreaseLevel} more times to get to the next LEVEL.");
                DisplayGoal();
            }
        }
    }

    // Add the Additional Points whenever the Times to level up is achieved.
    public override int AdditionalPoints(){
        if (_times <_timesToLevelUp ){
            return 0;
        }
        else{
            int level = _times / _timesToLevelUp;
            if (_times % _timesToLevelUp == 0){
                return (level * _levelPoints) + base.GetPoint();    // Double the points plus increase normal points according to _times 
                 
            }
            else{
                return level * _levelPoints; // Increase points according to _times
            }
        }
    }

}